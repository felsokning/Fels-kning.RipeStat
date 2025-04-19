//-----------------------------------------------------------------------
// <copyright file="RipeStatWrapper.cs" company="Felsökning">
//     Copyright (c) Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
//-----------------------------------------------------------------------
namespace Felsökning.RipeStat
{
    /// <summary>
    ///     Initializes a new instance of the Wrapper for the RIPE Stat API.
    /// </summary>
    /// <inheritdoc cref="HttpBase" />
    public class RipeStatWrapper : HttpBase
    {
        private readonly string baseUrl = "https://stat.ripe.net/data/whois/data.json?resource=";

        /// <summary>
        ///     Initializes a new instance of the Wrapper for the RIPE Stat API.
        /// </summary>
        /// <inheritdoc cref="HttpBase" />
        public RipeStatWrapper()
            : base(HttpVersion.Version20, "Felsökning.RipeStat")
        {
            this.HttpClient.BaseAddress = new Uri(this.baseUrl);
        }

        /// <summary>
        ///     Gets the WhoIs data for the specified resource.
        /// </summary>
        /// <param name="resource">The Resource to Query for. <para>e.g.: IP Address, CIDR, etc.</para></param>
        /// <returns>An awaitable <see cref="Task{TResult}"/> of <see cref="RipeStatResponse"/></returns>
        public async Task<RipeStatResponse> GetWhoIsDataAsync(string resource)
        {
            var url = $"{this.baseUrl}{resource}";
            return await this.HttpClient.GetAsync<RipeStatResponse>(url);
        }
    }
}