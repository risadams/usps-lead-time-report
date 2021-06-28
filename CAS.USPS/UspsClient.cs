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
using System.Net;
using CAS.USPS.Exceptions;
using CAS.USPS.Model;

#endregion

namespace CAS.USPS
{
    public class UspsClient
    {
        private const string PRODUCTION_URL = "http://production.shippingapis.com/ShippingAPI.dll";
        private const string TESTING_URL = "http://testing.shippingapis.com/ShippingAPITest.dll";
        private readonly string _userid;
        private readonly WebClient _web;

        /// <summary>
        ///     Creates a new USPS Manager instance
        /// </summary>
        /// <param name="uspsWebtoolUserID">The UserID required by the USPS Web Tools</param>
        public UspsClient(string uspsWebtoolUserID)
        {
            _web = new WebClient();
            _userid = uspsWebtoolUserID;
            TestMode = false;
        }

        /// <summary>
        ///     Creates a new USPS Manager instance
        /// </summary>
        /// <param name="uspsWebtoolUserID">The UserID required by the USPS Web Tools</param>
        /// <param name="testmode">If True, then the USPS Test URL will be used.</param>
        public UspsClient(string uspsWebtoolUserID, bool testmode)
        {
            TestMode = testmode;
            _web = new WebClient();
            _userid = uspsWebtoolUserID;
        }

        /// <summary>
        ///     Determines if the Calls to the USPS server is made to the Test or Production server.
        /// </summary>
        public bool TestMode { get; set; }

        /// <summary>
        ///     Gets the tracking information.
        /// </summary>
        /// <param name="trackingNumber">The tracking number.</param>
        /// <returns>TrackingInfo.</returns>
        /// <exception cref="UspsException">
        /// </exception>
        public TrackingInfo GetTrackingInfo(string trackingNumber)
        {
            try
            {
                const string trackurl = "?API=TrackV2&XML=<TrackRequest USERID=\"{0}\"><TrackID ID=\"{1}\"></TrackID></TrackRequest>";
                var url = GetUrl() + trackurl;
                url = String.Format(url, _userid, trackingNumber);
                var xml = _web.DownloadString(url);
                if (!xml.Contains("<Error>")) return TrackingInfo.FromXml(xml);
                var idx1 = xml.IndexOf("<Description>", StringComparison.Ordinal) + 13;
                var idx2 = xml.IndexOf("</Description>", StringComparison.Ordinal);
                var errDesc = xml.Substring(idx1, idx2 - idx1);
                throw new UspsException(errDesc);
            }
            catch (Exception ex)
            {
                throw new UspsException(ex);
            }
        }

        /// <summary>
        ///     Gets the URL.
        /// </summary>
        /// <returns>System.String.</returns>
        private string GetUrl()
        {
            return TestMode ? TESTING_URL : PRODUCTION_URL;
        }
    }
}