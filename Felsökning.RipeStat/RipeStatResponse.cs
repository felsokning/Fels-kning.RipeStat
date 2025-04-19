//-----------------------------------------------------------------------
// <copyright file="RipeStatResponse.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.RipeStat
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="RipeStatResponse"/> class.
    /// </summary>
    public class RipeStatResponse
    {
        /// <summary>
        ///     Gets or sets the list of messages returned by the API.
        /// </summary>
        [JsonPropertyName("messages")]
        public List<List<string>> Messages { get; set; } = [];

        /// <summary>
        ///     Gets or sets the list of links to related data calls.
        /// </summary>
        [JsonPropertyName("see_also")]
        public List<object> SeeAlso { get; set; } = [];

        /// <summary>
        ///     Gets or sets the major.minor version of the response layout for this particular data call.
        ///     <para>New minor versions are backwards compatible, new major versions are not.</para>
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the name of the data call.
        ///     <para>This is useful for the RIPE team and when only the API output is available in a support request.</para>
        /// </summary>
        [JsonPropertyName("data_call_name")]
        public string DataCallName { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the the status of the data call.
        ///     <para>Possible values:
        ///     <list type="bullet">
        ///         <item>
        ///             <term>supported </term>
        ///             <description>This data call is meant to be stable and without bugs. Any bugs reported will be fixed asap.</description>
        ///         </item>
        ///         <item>
        ///             <term>deprecated</term>
        ///             <description>This data call is meant to be deprecated and is about to be removed either by the expiration date or soon.</description>
        ///         </item>
        ///         <item>
        ///             <term>development</term>
        ///             <description>This data call is currently work in progress and to be considered to change or discontinued without notice.</description>
        ///         </item>
        ///     </list>
        ///     </para>
        /// </summary>
        [JsonPropertyName("data_call_status")]
        public string DataCallStatus { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets a <see cref="bool"/>, indicating the results were retrieved from cache.
        /// </summary>
        [JsonPropertyName("cached")]
        public bool Cached { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="RipeStatData"/> itself.
        /// </summary>
        [JsonPropertyName("data")]
        public RipeStatData Data { get; set; } = new RipeStatData();

        /// <summary>
        ///     Gets or sets the query ID of the data call.
        /// </summary>
        [JsonPropertyName("query_id")]
        public string QueryId { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the processing time of the data call.
        /// </summary>
        [JsonPropertyName("process_time")]
        public int ProcessTime { get; set; }

        /// <summary>
        ///     Gets or sets the server ID of the server that processed the data call.
        /// </summary>
        [JsonPropertyName("server_id")]
        public string ServerId { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the build version of the server that processed the data call.
        /// </summary>
        [JsonPropertyName("build_version")]
        public string BuildVersion { get; set; } = string.Empty;

        /// <summary>
        ///    Gets or sets the status of the result of the data call.
        ///     <para>Possible values:
        ///     <list type="bullet">
        ///         <item>
        ///             <term>ok</term>
        ///             <description>A successful query</description>
        ///         </item>
        ///         <item>
        ///             <term>error</term>
        ///             <description>An unsuccessful query</description>
        ///         </item>
        ///         <item>
        ///             <term>maintenance</term>
        ///             <description>The data call is undergoing maintenance</description>
        ///         </item>
        ///     </list>
        ///     </para>
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        /// <summary>
        ///    Gets or sets the status code of the result of the data call.
        ///    <para>Same as the HTTP status code.</para>
        ///    <para>In case of server errors the HTTP status code will be set appropriately.</para>
        /// </summary>
        [JsonPropertyName("status_code")]
        public int StatusCode { get; set; }

        /// <summary>
        ///     Gets or sets the time of the data call.
        /// </summary>
        [JsonPropertyName("time")]
        public DateTime Time { get; set; }
    }
}