//-----------------------------------------------------------------------
// <copyright file="RipeStatData.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.RipeStat
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="RipeStatData"/> class.
    /// </summary>
    public class RipeStatData
    {
        /// <summary>
        ///     Gets or sets a list of whois records returned for this resource (authorities are combined)
        /// </summary>
        [JsonPropertyName("records")]
        public List<List<RipeStatRecord>> Records { get; set; } = [];

        /// <summary>
        ///     Gets or sets a list of records returned for Routing Registries (RIPE, RADB...)
        /// </summary>
        [JsonPropertyName("irr_records")]
        public List<List<RipeStatIrrRecord>> IrrRecords { get; set; } = [];

        /// <summary>
        ///     Gets or sets the the authorities that were involved in the query (e.g. "ripe", "afrinic", "apnic", "lacnic", "arin", "iana") 
        /// </summary>
        [JsonPropertyName("authorities")]
        public List<string> Authorities { get; set; } = [];

        /// <summary>
        ///     Gets or sets the resource the query was based on
        /// </summary>
        [JsonPropertyName("resource")]
        public string Resource { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the time the query was based on 
        /// </summary>
        [JsonPropertyName("query_time")]
        public DateTime QueryTime { get; set; }
    }
}