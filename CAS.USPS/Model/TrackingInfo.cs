// -----------------------------------------------------------------------
//  <copyright project="CAS.USPS"
//             assembly="libcasusps"
//             solution="CAS.USPS"
//             company="Chris Adams Studios">
//      Copyright (c) 1996+. All rights reserved.
//  </copyright>
//  <author id="chris@chrisadams-studios.com">Chris Adams</author>
//  <summary></summary>
// -----------------------------------------------------------------------

#region References

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

#endregion

namespace CAS.USPS.Model
{
    [Serializable]
    [DebuggerDisplay("{Summary}")]
    public class TrackingInfo
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="TrackingInfo" /> class.
        /// </summary>
        public TrackingInfo()
        {
            Details = new List<string>();
        }

        /// <summary>
        ///     The tracking number for the package
        /// </summary>
        public string TrackingNumber { get; set; }

        /// <summary>
        ///     Summary information for the package
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        ///     Gets the delivery date.
        /// </summary>
        /// <value>The delivery date.</value>
        public DateTime? DeliveryDate
        {
            get { return string.IsNullOrEmpty(Summary) ? null : TryParseDateTime(Summary); }
        }

        /// <summary>
        ///     Gets a value indicating whether this instance is delivered.
        /// </summary>
        /// <value><c>true</c> if this instance is delivered; otherwise, <c>false</c>.</value>
        public bool IsDelivered
        {
            get { return DeliveryDate != null; }
        }

        /// <summary>
        ///     Gets a value indicating whether this instance is alerted.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <value><c>true</c> if this instance is alerted; otherwise, <c>false</c>.</value>
        public bool IsAlerted
        {
            get
            {
                return !(string.IsNullOrEmpty(Summary))
                       && Summary.Contains("item was forwarded to a different address");
            }
        }

        /// <summary>
        ///     Gets a value indicating whether this instance is in transit.
        /// </summary>
        /// <value><c>true</c> if an item is in transit; otherwise, <c>false</c>.</value>
        public bool InTransit
        {
            get
            {
                return !(string.IsNullOrEmpty(Summary))
                       && (Summary.Contains("Your item departed ") || Summary.Contains("Your item is out for delivery "));
            }
        }

        /// <summary>
        ///     Tracking Details
        /// </summary>
        public List<string> Details { get; set; }

        /// <summary>
        ///     Tries to parse a date time from the summary of a delivered package.
        /// </summary>
        /// <param name="summary">The summary.</param>
        /// <returns>System.Nullable{DateTime}.</returns>
        private static DateTime? TryParseDateTime(string summary)
        {
            try
            {
                const string pattern = @"at (?<Time>.+) on (?<Date>.+) in";
                var regex = new Regex(pattern, RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.IgnoreCase);

                var dateTime = new DateTime();
                return (from Match match in regex.Matches(summary)
                    where match.Success
                    let time = match.Groups["Time"].Value
                    let date = match.Groups["Date"].Value
                    select string.Format(CultureInfo.InvariantCulture, "{0} {1}", date, time))
                    .Any(dateString => DateTime.TryParse(dateString, out dateTime))
                    ? (DateTime?) dateTime
                    : null;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        ///     Parses the specified XML into a TrackingInfo object.
        /// </summary>
        /// <param name="xml">The XML.</param>
        /// <returns>TrackingInfo.</returns>
        public static TrackingInfo FromXml(string xml)
        {
            int idx1;
            int idx2;
            var t = new TrackingInfo();
            if (xml.Contains("<TrackSummary>"))
            {
                idx1 = xml.IndexOf("<TrackSummary>", StringComparison.Ordinal) + 14;
                idx2 = xml.IndexOf("</TrackSummary>", StringComparison.Ordinal);
                t.Summary = xml.Substring(idx1, idx2 - idx1);
            }
            var lastidx = 0;
            while (xml.IndexOf("<TrackDetail>", lastidx, StringComparison.Ordinal) > -1)
            {
                idx1 = xml.IndexOf("<TrackDetail>", lastidx, StringComparison.Ordinal) + 13;
                idx2 = xml.IndexOf("</TrackDetail>", lastidx + 13, StringComparison.Ordinal);
                t.Details.Add(xml.Substring(idx1, idx2 - idx1));
                lastidx = idx2;
            }
            return t;
        }
    }
}