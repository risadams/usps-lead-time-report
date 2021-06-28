#region References

using CAS.USPS.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace CAS.USPS.Test
{
    [TestClass]
    public class PostalServiceTests
    {
        private const string USERNAME = @"170PHILI1631";
        private UspsClient _client;

        [TestInitialize]
        public void Setup()
        {
            _client = new UspsClient(USERNAME, true);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _client = null;
        }

        [TestMethod]
        public void VerifyTestSetup()
        {
            Assert.IsNotNull(_client);
            Assert.IsTrue(_client.TestMode);
        }

        [TestMethod]
        public void VerifyDateTimeParse()
        {
            const string sample = "Your item was delivered at 2:45 pm on January 10, 2014 in NEW RIVER, AZ 85087.";
            var info = new TrackingInfo {Summary = sample};
            var dateTime = info.DeliveryDate;

            Assert.IsNotNull(dateTime);
            Assert.AreEqual(1, dateTime.Value.Month);
            Assert.AreEqual(10, dateTime.Value.Day);
            Assert.AreEqual(2014, dateTime.Value.Year);
            Assert.AreEqual(14, dateTime.Value.Hour);
            Assert.AreEqual(45, dateTime.Value.Minute);
        }

        [TestMethod]
        public void VerifySampleDataFromPpmToClient()
        {
            const string tracker = @"9274893250801603947252";
            var trackInfo = _client.GetTrackingInfo(tracker);
            
            Assert.IsNotNull(trackInfo);
            Assert.IsNotNull(trackInfo.Summary);
            Assert.IsNotNull(trackInfo.Details);

            Assert.AreEqual(@"Your item was delivered at 2:45 pm on January 10, 2014 in NEW RIVER, AZ 85087.", trackInfo.Summary);
            Assert.AreEqual(6, trackInfo.Details.Count);

            Assert.AreEqual(@"Out for Delivery, January 10, 2014, 9:04 am, NEW RIVER, AZ 85087", trackInfo.Details[0]);
            Assert.AreEqual(@"Sorting Complete, January 10, 2014, 8:54 am, NEW RIVER, AZ 85087", trackInfo.Details[1]);
            Assert.AreEqual(@"Arrival at Post Office, January 10, 2014, 3:22 am, NEW RIVER, AZ 85087", trackInfo.Details[2]);
            Assert.AreEqual(@"Electronic Shipping Info Received, January 9, 2014", trackInfo.Details[3]);
            Assert.AreEqual(@"Departed Shipping Partner Facility, January 7, 2014, 6:54 am, HEBRON, KY 41048", trackInfo.Details[4]);
            Assert.AreEqual(@"Arrived Shipping Partner Facility, January 7, 2014, 1:25 am, HEBRON, KY 41048", trackInfo.Details[5]);
        }

        [TestMethod]
        public void VerifySampleDataFromClientToPpm()
        {
            const string tracker = @"9400110200830103285744";
            var trackInfo = _client.GetTrackingInfo(tracker);

            Assert.IsNotNull(trackInfo);
            Assert.IsNotNull(trackInfo.Summary);
            Assert.IsNotNull(trackInfo.Details);

            Assert.AreEqual(@"Your item was delivered at 9:56 am on January 29, 2014 in GLENDALE, AZ 85306.", trackInfo.Summary);
            Assert.AreEqual(8, trackInfo.Details.Count);
        }
    }
}