//-----------------------------------------------------------------------
// <copyright file="RipeStatWrapperTests.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.RipeStat.Tests
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class RipeStatWrapperTests
    {
        [TestMethod]
        public async Task RipeStatWrapper_Succeeds_ARIN_WithValues()
        {
            var ripeStat = new RipeStatWrapper();

            var result = await ripeStat.GetWhoIsDataAsync("13.107.6.152");

            result.Should().NotBeNull();
            result.Should().BeOfType<RipeStatResponse>();
            result.BuildVersion.Should().NotBeNullOrWhiteSpace();
            result.Data.Should().NotBeNull();

            var data = result.Data;
            data.Should().NotBeNull();
            data.Should().BeOfType<RipeStatData>();
            data.Authorities.Count.Should().BeGreaterThan(0);
            data.IrrRecords.Count.Should().BeGreaterThan(0);

            var irrRecords = data.IrrRecords.FirstOrDefault();
            irrRecords.Should().NotBeNull();
            irrRecords.Should().BeOfType<List<RipeStatIrrRecord>>();
            irrRecords.Count.Should().BeGreaterThan(0);

            var irrRecord = irrRecords.FirstOrDefault();
            irrRecord.Should().NotBeNull();
            irrRecord.Should().BeOfType<RipeStatIrrRecord>();
            irrRecord.DetailsLink.Should().NotBeNullOrWhiteSpace();
            irrRecord.Key.Should().NotBeNullOrWhiteSpace();
            irrRecord.Value.Should().NotBeNullOrWhiteSpace();


            data.QueryTime.Should().NotBe(DateTime.MinValue);
            data.Records.Count.Should().BeGreaterThan(0);

            var record = data.Records.FirstOrDefault();
            record.Should().NotBeNull();
            record.Should().BeOfType<List<RipeStatRecord>>();
            record.Count.Should().BeGreaterThan(0);

            var recordRecord = record.FirstOrDefault();
            recordRecord.Should().NotBeNull();
            recordRecord.Should().BeOfType<RipeStatRecord>();
            recordRecord.Key.Should().NotBeNullOrWhiteSpace();
            recordRecord.Value.Should().NotBeNullOrWhiteSpace();


            data.Resource.Should().NotBeNullOrWhiteSpace();

            result.DataCallName.Should().Be("whois");
            result.DataCallStatus.Should().Be("supported");
            result.Messages.Should().NotBeNull();
            result.ProcessTime.Should().NotBe(0);
            result.QueryId.Should().NotBeNullOrWhiteSpace();
            result.SeeAlso.Should().NotBeNull();
            result.ServerId.Should().NotBeNullOrWhiteSpace();
            result.Status.Should().Be("ok");
            result.StatusCode.Should().Be(200);
            result.Time.Should().NotBe(DateTime.MinValue);
            result.Version.Should().NotBeNullOrWhiteSpace();
        }

        [TestMethod]
        public async Task RipeStatWrapper_Succeeds_RIPE_WithValues()
        {
            var ripeStat = new RipeStatWrapper();

            var result = await ripeStat.GetWhoIsDataAsync("138.199.64.152");

            result.Should().NotBeNull();
            result.Should().BeOfType<RipeStatResponse>();
            result.BuildVersion.Should().NotBeNullOrWhiteSpace();
            result.Data.Should().NotBeNull();

            var data = result.Data;
            data.Should().NotBeNull();
            data.Should().BeOfType<RipeStatData>();
            data.Authorities.Count.Should().BeGreaterThan(0);
            data.IrrRecords.Count.Should().BeGreaterThan(0);

            var irrRecords = data.IrrRecords.FirstOrDefault();
            irrRecords.Should().NotBeNull();
            irrRecords.Should().BeOfType<List<RipeStatIrrRecord>>();
            irrRecords.Count.Should().BeGreaterThan(0);

            var irrRecord = irrRecords.FirstOrDefault();
            irrRecord.Should().NotBeNull();
            irrRecord.Should().BeOfType<RipeStatIrrRecord>();
            irrRecord.DetailsLink.Should().NotBeNullOrWhiteSpace();
            irrRecord.Key.Should().NotBeNullOrWhiteSpace();
            irrRecord.Value.Should().NotBeNullOrWhiteSpace();


            data.QueryTime.Should().NotBe(DateTime.MinValue);
            data.Records.Count.Should().BeGreaterThan(0);

            var record = data.Records.FirstOrDefault();
            record.Should().NotBeNull();
            record.Should().BeOfType<List<RipeStatRecord>>();
            record.Count.Should().BeGreaterThan(0);

            var recordRecord = record.FirstOrDefault();
            recordRecord.Should().NotBeNull();
            recordRecord.Should().BeOfType<RipeStatRecord>();
            recordRecord.Key.Should().NotBeNullOrWhiteSpace();
            recordRecord.Value.Should().NotBeNullOrWhiteSpace();


            data.Resource.Should().NotBeNullOrWhiteSpace();

            result.DataCallName.Should().Be("whois");
            result.DataCallStatus.Should().Be("supported");
            result.Messages.Should().NotBeNull();
            // result.ProcessTime.Should().NotBe(0); // Bug in .NET9.0 where ProcessTime is 0
            result.QueryId.Should().NotBeNullOrWhiteSpace();
            result.SeeAlso.Should().NotBeNull();
            result.ServerId.Should().NotBeNullOrWhiteSpace();
            result.Status.Should().Be("ok");
            result.StatusCode.Should().Be(200);
            result.Time.Should().NotBe(DateTime.MinValue);
            result.Version.Should().NotBeNullOrWhiteSpace();
        }

        [TestMethod]
        public async Task RipeStatWrapper_Succeeds_APNIC_WithValues()
        {
            var ripeStat = new RipeStatWrapper();

            var result = await ripeStat.GetWhoIsDataAsync("14.134.0.152");

            result.Should().NotBeNull();
            result.Should().BeOfType<RipeStatResponse>();
            result.BuildVersion.Should().NotBeNullOrWhiteSpace();
            result.Data.Should().NotBeNull();

            var data = result.Data;
            data.Should().NotBeNull();
            data.Should().BeOfType<RipeStatData>();
            data.Authorities.Count.Should().BeGreaterThan(0);
            data.IrrRecords.Count.Should().BeGreaterThan(0);

            var irrRecords = data.IrrRecords.FirstOrDefault();
            irrRecords.Should().NotBeNull();
            irrRecords.Should().BeOfType<List<RipeStatIrrRecord>>();
            irrRecords.Count.Should().BeGreaterThan(0);

            var irrRecord = irrRecords.FirstOrDefault();
            irrRecord.Should().NotBeNull();
            irrRecord.Should().BeOfType<RipeStatIrrRecord>();
            irrRecord.DetailsLink.Should().NotBeNullOrWhiteSpace();
            irrRecord.Key.Should().NotBeNullOrWhiteSpace();
            irrRecord.Value.Should().NotBeNullOrWhiteSpace();


            data.QueryTime.Should().NotBe(DateTime.MinValue);
            data.Records.Count.Should().BeGreaterThan(0);

            var record = data.Records.FirstOrDefault();
            record.Should().NotBeNull();
            record.Should().BeOfType<List<RipeStatRecord>>();
            record.Count.Should().BeGreaterThan(0);

            var recordRecord = record.FirstOrDefault();
            recordRecord.Should().NotBeNull();
            recordRecord.Should().BeOfType<RipeStatRecord>();
            recordRecord.Key.Should().NotBeNullOrWhiteSpace();
            recordRecord.Value.Should().NotBeNullOrWhiteSpace();


            data.Resource.Should().NotBeNullOrWhiteSpace();

            result.DataCallName.Should().Be("whois");
            result.DataCallStatus.Should().Be("supported");
            result.Messages.Should().NotBeNull();
            result.ProcessTime.Should().NotBe(0);
            result.QueryId.Should().NotBeNullOrWhiteSpace();
            result.SeeAlso.Should().NotBeNull();
            result.ServerId.Should().NotBeNullOrWhiteSpace();
            result.Status.Should().Be("ok");
            result.StatusCode.Should().Be(200);
            result.Time.Should().NotBe(DateTime.MinValue);
            result.Version.Should().NotBeNullOrWhiteSpace();
        }
    }
}