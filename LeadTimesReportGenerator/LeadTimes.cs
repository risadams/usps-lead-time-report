#region References

using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CAS.USPS;
using CAS.USPS.Exceptions;
using CAS.USPS.Model;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraPrinting;
using Excel;
using LeadTimesReportGenerator.Properties;

#endregion

namespace LeadTimesReportGenerator
{
    public partial class LeadTimes : RibbonForm
    {
        private DataTable _data;
        private string _fromTrackerColumName;

        private bool _fromTrackerColumnSet;
        private string _toTrackerColumName;
        private bool _toTrackerColumnSet;

        private readonly List<string> _flaggedColumnList = new List<string>();

        public LeadTimes()
        {
            InitializeComponent();
            RefreshTrackerColumns();
            RefreshMailSync();
            RefreshExportButton();
        }

        private string SelectedFromTrackerColumn
        {
            get { return _fromTrackerColumName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _fromTrackerColumName = null;
                    _fromTrackerColumnSet = false;
                }
                else
                {
                    _fromTrackerColumName = value;
                    _fromTrackerColumnSet = true;
                    RefreshMailSync();
                }
            }
        }

        private string SelectedToTrackerColumn
        {
            get { return _toTrackerColumName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _toTrackerColumName = null;
                    _toTrackerColumnSet = false;
                }
                else
                {
                    _toTrackerColumName = value;
                    _toTrackerColumnSet = true;
                    RefreshMailSync();
                }
            }
        }

        private List<Tuple<string, string>> TrackingNumbers { get; set; }

        private void RefreshTrackerColumns()
        {
            bbtnSetFromColumn.Enabled = _data != null;
            bbtnSetToColumn.Enabled = _data != null;
        }

        private void RefreshMailSync()
        {
            bbtnMailsync.Enabled = _fromTrackerColumnSet && _toTrackerColumnSet;
        }

        private void RefreshExportButton()
        {
            bbtnExcelExport.Enabled = gridResults.Visible;
        }

        private void bbtnOpen_ItemClick(object sender, ItemClickEventArgs e)
        {
            var dialog = new OpenFileDialog {Filter = "Excel Files (*.xls, *.xlsx)|*.xls;*.xlsx"};
            if (dialog.ShowDialog(this) != DialogResult.OK)
                return;

            var cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            splashManager.ShowWaitForm();

            LoadData(dialog);

            Cursor.Current = cursor;
            splashManager.CloseWaitForm();
        }

        private void LoadData(OpenFileDialog dialog)
        {
            _data = null;
            if (dialog.SafeFileName == null)
                return;

            if (dialog.SafeFileName.EndsWith(".xls"))
            {
                _data = OpenBinaryData(dialog);
            }

            if (dialog.SafeFileName.EndsWith(".xlsx"))
            {
                _data = OpenXmlData(dialog);
            }

            Invoke((MethodInvoker) delegate
            {
                gridDataInfo.DataSource = _data;
                gridDataInfo.RefreshDataSource();
                gridDataInfo.Invalidate();

                gridDataInfo.Visible = true;
                gridResults.Visible = false;

                RefreshTrackerColumns();
            });
        }

        private static DataTable OpenXmlData(OpenFileDialog dialog)
        {
            using (var file = dialog.OpenFile())
            using (var excelReader = ExcelReaderFactory.CreateOpenXmlReader(file))
            {
                excelReader.IsFirstRowAsColumnNames = true;
                return excelReader.AsDataSet(true).Tables[0];
            }
        }

        private static DataTable OpenBinaryData(OpenFileDialog dialog)
        {
            using (var file = dialog.OpenFile())
            using (var excelReader = ExcelReaderFactory.CreateBinaryReader(file))
            {
                excelReader.IsFirstRowAsColumnNames = true;
                return excelReader.AsDataSet(true).Tables[0];
            }
        }

        private void bbtnSetFromColumn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Invoke((MethodInvoker) delegate
            {
                var focusedColumn = gridDataView.FocusedColumn;

                SelectedFromTrackerColumn = focusedColumn.FieldName;

                RefreshMailSync();
            });
        }

        private void bbtnSetToColumn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Invoke((MethodInvoker) delegate
            {
                var focusedColumn = gridDataView.FocusedColumn;

                SelectedToTrackerColumn = focusedColumn.FieldName;

                RefreshMailSync();
            });
        }

        private void bbtnMailsync_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_data == null)
                return;

            TrackingNumbers = new List<Tuple<string, string>>();

            foreach (DataRow row in _data.Rows)
            {
                var from = StripQuotes(row[SelectedFromTrackerColumn].ToString());
                var to = StripQuotes(row[SelectedToTrackerColumn].ToString());

                TrackingNumbers.Add(new Tuple<string, string>(from, to));
            }

            var cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            splashManager.ShowWaitForm();

            BuildCompareReport(TrackingNumbers);

            Cursor.Current = cursor;
            splashManager.CloseWaitForm();
        }

        private static string StripQuotes(string value)
        {
            return string.IsNullOrEmpty(value) ? string.Empty : value.Replace("\"", string.Empty).Replace("'", string.Empty);
        }

        private void BuildCompareReport(IEnumerable<Tuple<string, string>> trackingNumbers)
        {
            var success = new List<Tuple<TrackingInfo, TrackingInfo>>();
            var error = new List<Tuple<Tuple<string, string>, string>>();

            var client = new UspsClient(Settings.Default.USPS_User, false);
            foreach (var trackingNumber in trackingNumbers)
            {
                try
                {
                    var from = trackingNumber.Item1;
                    var to = trackingNumber.Item2;

                    if (string.IsNullOrEmpty(from) && string.IsNullOrEmpty(to))
                        continue;

                    var fromTrackingInfo = !string.IsNullOrEmpty(@from)
                        ? client.GetTrackingInfo(@from)
                        : new TrackingInfo {Summary = "NO TRACKING INFO"};
                    fromTrackingInfo.TrackingNumber = from;

                    var toTrackingInfo = !string.IsNullOrEmpty(to)
                        ? client.GetTrackingInfo(to)
                        : new TrackingInfo {Summary = "NO TRACKING INFO"};
                    toTrackingInfo.TrackingNumber = to;

                    success.Add(new Tuple<TrackingInfo, TrackingInfo>(fromTrackingInfo, toTrackingInfo));
                }
                catch (UspsException e)
                {
                    error.Add(new Tuple<Tuple<string, string>, string>(trackingNumber, e.Message));
                }
            }

            var table = new DataTable();
            table.Columns.Add("Tracking From", typeof (string));
            table.Columns.Add("Summary From", typeof (string));
            table.Columns.Add("Date From", typeof (DateTime));
            table.Columns.Add("Tracking To", typeof (string));
            table.Columns.Add("Summary To", typeof (string));
            table.Columns.Add("Date To", typeof (DateTime));

            foreach (var item in success)
            {
                var row = table.NewRow();
                row["Tracking From"] = item.Item1.TrackingNumber;
                row["Summary From"] = item.Item1.Summary;
                row["Date From"] = item.Item1.DeliveryDate ?? DateTime.MinValue;
                row["Tracking To"] = item.Item2.TrackingNumber;
                row["Summary To"] = item.Item2.Summary;
                row["Date To"] = item.Item2.DeliveryDate ?? DateTime.MinValue;

                table.Rows.Add(row);
            }

            Invoke((MethodInvoker) delegate
            {
                _data = null;
                SelectedFromTrackerColumn = null;
                SelectedToTrackerColumn = null;

                RefreshTrackerColumns();
                RefreshMailSync();

                gridResults.DataSource = table;
                gridResults.RefreshDataSource();
                gridResults.Invalidate();

                gridResultsView.Columns["Date From"].ColumnEdit = new RepositoryItemDateEdit();
                ((RepositoryItemDateEdit) gridResultsView.Columns["Date From"].ColumnEdit).NullDate = DateTime.MinValue;
                
                gridResultsView.Columns["Date From"].ColumnEdit.NullText = "";
                gridResultsView.Columns["Date From"].DisplayFormat.FormatType = FormatType.DateTime;
                gridResultsView.Columns["Date From"].DisplayFormat.FormatString = "g";

                gridResultsView.Columns["Date To"].ColumnEdit = new RepositoryItemDateEdit();
                ((RepositoryItemDateEdit)gridResultsView.Columns["Date To"].ColumnEdit).NullDate = DateTime.MinValue;
                
                gridResultsView.Columns["Date To"].ColumnEdit.NullText = "";
                gridResultsView.Columns["Date To"].DisplayFormat.FormatType = FormatType.DateTime;
                gridResultsView.Columns["Date To"].DisplayFormat.FormatString = "g";

                gridDataInfo.Visible = false;
                gridResults.Visible = true;
                RefreshExportButton();
            });
        }

        private void bbtnTrackingSummary_ItemClick(object sender, ItemClickEventArgs e)
        {
            Invoke((MethodInvoker) delegate
            {
                var value = gridDataView.FocusedValue.ToString();


                var stripValue = StripQuotes(value);
                var client = new UspsClient(Settings.Default.USPS_User, false);

                try
                {
                    var results = client.GetTrackingInfo(stripValue);
                    MessageBox.Show(this, string.Format(CultureInfo.CurrentCulture, "Summary: {0}", results.Summary),
                        string.Format(CultureInfo.CurrentCulture, "Tracking Number: {0}", value), MessageBoxButtons.OK, results.IsAlerted ? MessageBoxIcon.Error : MessageBoxIcon.None);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving details: " + ex.Message);
                }
            });
        }

        private void bbtnTrackingDetails_ItemClick(object sender, ItemClickEventArgs e)
        {
            var value = gridDataView.FocusedValue.ToString();

            var stripValue = StripQuotes(value);
            var client = new UspsClient(Settings.Default.USPS_User, false);
            try
            {
                var results = client.GetTrackingInfo(stripValue);
                MessageBox.Show(this, FormatDetails(results), string.Format(CultureInfo.CurrentCulture, "Tracking Number: {0}", value), MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving details: " + ex.Message);
            }
        }

        private static string FormatDetails(TrackingInfo trackingInfo)
        {
            var builder = new StringBuilder();
            builder.AppendLine(string.Format(CultureInfo.CurrentCulture, "Summary: {0}", trackingInfo.Summary));

            if (trackingInfo.Details.Count == 0)
                builder.AppendLine(string.Format(CultureInfo.CurrentCulture, "** No Detailed Information available"));
            else
            {
                var count = 1;
                builder.AppendLine(string.Format(CultureInfo.CurrentCulture, "Details:"));
                foreach (var detail in trackingInfo.Details)
                {
                    builder.AppendLine(string.Format(CultureInfo.CurrentCulture, "{0}: {1}", count, detail));
                    count++;
                }
            }
            return builder.ToString();
        }

        private void bbtnExcelExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            Invoke((MethodInvoker) delegate
            {
                var dialog = new SaveFileDialog {Filter = "Excel File (*.xlsx)|*.xlsx"};
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        gridResults.ExportToXlsx(dialog.FileName, new XlsxExportOptions
                        {
                            RawDataMode = true,
                            ShowGridLines = true,
                            SheetName = "USPS Report",
                            ExportMode = XlsxExportMode.SingleFile,
                            TextExportMode = TextExportMode.Value
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving file " + ex.Message);
                        return;
                    }

                    try
                    {
                        Process.Start(dialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error starting application " + ex.Message);
                    }
                }
            });
        }

        private void btnFlagColumn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                var focusedColumn = gridDataView.FocusedColumn;

                SelectedFromTrackerColumn = focusedColumn.FieldName;

                if (_flaggedColumnList.Contains(focusedColumn.FieldName))
                    _flaggedColumnList.Remove(focusedColumn.FieldName);
                else
                    _flaggedColumnList.Add(focusedColumn.FieldName);

                HighlightFlaggedColumns();
            });
        }

        private void HighlightFlaggedColumns()
        {
            Invoke((MethodInvoker) delegate
            {
                var columns = gridDataView.Columns;
                foreach (GridColumn column in columns)
                {
                    var name = column.FieldName;
                    column.AppearanceCell.BackColor = _flaggedColumnList.Contains(name) ? Color.LightYellow : Color.White;
                }
            });
        }

        private void bbtnStatusReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                if (_data == null) return;
                if (_flaggedColumnList.Count < 1)
                {
                    MessageBox.Show("No columns flagged for reporting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    return;
                }

                var trackingNumbers = (from DataRow row in _data.Rows
                    from columnName in _flaggedColumnList
                    select StripQuotes(row[columnName].ToString())).ToList();

                var cursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                splashManager.ShowWaitForm();

                BuildStatusReport(trackingNumbers);

                Cursor.Current = cursor;
                splashManager.CloseWaitForm();
            });
        }

        private void BuildStatusReport(IEnumerable<string> trackingNumbers)
        {
            //results tuple
            // 1) Tracking Number
            // 2) success/fail
            // 3) Tracking Info
            // 4) error info
            var results = new List<Tuple<string, bool, TrackingInfo,string>>();
            var client = new UspsClient(Settings.Default.USPS_User, false);
            foreach (var trackingNumber in trackingNumbers)
            {
                try
                {
                    var trackingInfo = client.GetTrackingInfo(trackingNumber);
                    results.Add(new Tuple<string, bool, TrackingInfo, string>(trackingNumber, true, trackingInfo, null));
                }
                catch (Exception e)
                {
                    results.Add(new Tuple<string, bool, TrackingInfo, string>(trackingNumber, false, null, e.Message));
                }
            }

            var table = new DataTable();
            table.Columns.Add("TrackerToDME", typeof (string));
            table.Columns.Add("Valid Result", typeof (bool));
            table.Columns.Add("Is Delivered", typeof(bool));
            table.Columns.Add("Is Alerted", typeof(bool));
            table.Columns.Add("In Transit", typeof(bool));
            table.Columns.Add("Summary", typeof (string));            
            table.Columns.Add("Modem Delivery Date", typeof (string));

            foreach (var result in results)
            {
                var row = table.NewRow();
                row["TrackerToDME"] = result.Item1;
                row["Valid Result"] = result.Item2;

                if (result.Item2)
                {
                    row["Summary"] = result.Item3.Summary;
                    row["Is Delivered"] = result.Item3.IsDelivered;
                    row["Is Alerted"] = result.Item3.IsAlerted;
                    row["In Transit"] = result.Item3.InTransit;
                    row["Modem Delivery Date"] = result.Item3.InTransit
                        ? "In Transit"
                        : (result.Item3.DeliveryDate.HasValue ? result.Item3.DeliveryDate.Value.ToShortDateString() : "");
                }
                else
                {
                    row["Summary"] = result.Item4;
                    row["Is Delivered"] = false;
                    row["Is Alerted"] = false;
                    row["In Transit"] = false;
                    row["Modem Delivery Date"] = "";
                }

                table.Rows.Add(row);
            }
            Invoke((MethodInvoker) delegate
            {
                gridResults.DataSource = table;
                gridResults.RefreshDataSource();
                gridResults.Invalidate();

                var deliveredCondition = new StyleFormatCondition();
                deliveredCondition.Appearance.BackColor = Color.FromArgb(0, 105, 60);
                deliveredCondition.Appearance.BackColor2 = Color.FromArgb(91, 143, 34);
                deliveredCondition.Appearance.ForeColor = Color.FromArgb(224, 233, 110);
                deliveredCondition.Appearance.GradientMode = LinearGradientMode.Vertical;
                deliveredCondition.Appearance.Options.UseBackColor = true;
                deliveredCondition.Appearance.Options.UseForeColor = true;
                deliveredCondition.Condition = FormatConditionEnum.Expression;
                deliveredCondition.Expression = @"[Is Delivered] == True";

                var alertedCondition = new StyleFormatCondition();
                alertedCondition.Appearance.BackColor = Color.FromArgb(150,23,46);
                alertedCondition.Appearance.BackColor2 = Color.FromArgb(94,23,45);
                alertedCondition.Appearance.ForeColor = Color.FromArgb(229,154,170);
                alertedCondition.Appearance.GradientMode = LinearGradientMode.Vertical;
                alertedCondition.Appearance.Options.UseBackColor = true;
                alertedCondition.Appearance.Options.UseForeColor = true;
                alertedCondition.Condition = FormatConditionEnum.Expression;
                alertedCondition.Expression = @"[Is Alerted] == True";

                gridResultsView.FormatConditions.Add(deliveredCondition);
                gridResultsView.FormatConditions.Add(alertedCondition);

                gridDataInfo.Visible = false;
                gridResults.Visible = true;
                RefreshExportButton();
            });
        }
    }
}