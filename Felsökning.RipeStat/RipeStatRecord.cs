//-----------------------------------------------------------------------
// <copyright file="RipeStatRecord.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.RipeStat
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="RipeStatRecord"/> class.
    /// </summary>
    public class RipeStatRecord
    {
        /// <summary>
        ///     Gets or sets the type of the entry (e.g. "aut-num", "as-name"...)
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; } = string.Empty;

        /// <summary>
        ///     Gets ir sets the value of that entry
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets a link with further information (either on RIPEstat or the responsible whois database)
        /// </summary>
        [JsonPropertyName("details_link")]
        public string DetailsLink { get; set; } = string.Empty;
    }
}