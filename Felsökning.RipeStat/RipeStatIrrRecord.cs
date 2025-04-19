//-----------------------------------------------------------------------
// <copyright file="RipeStatIrrRecord.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.RipeStat
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="RipeStatIrrRecord"/> class.
    /// </summary>
    public class RipeStatIrrRecord
    {
        /// <summary>
        ///     Gets or sets type of the entry (e.g. "route", "descr", "origin", "source"...)
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the value of that entry
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets a link with further informations (either on RIPEstat or the responsible IRR database)
        /// </summary>
        [JsonPropertyName("details_link")]
        public string DetailsLink { get; set; } = string.Empty;
    }
}