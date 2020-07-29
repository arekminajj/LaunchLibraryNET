using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using LaunchLibraryNET.Models;
using Flurl.Http;
using Newtonsoft.Json;

namespace LaunchLibraryNET
{
    public class Client
    {
        private readonly string _apiKey;
        private const string BaseUrl = "https://lldev.thespacedevs.com/2.0.0";

        public Client(string apiKey)
        {
            _apiKey = apiKey;
        }

        public Client()
        {
            
        }

        public async Task<Agencies> GetAgencies(
            string featured="",
            string agency_type="",
            string country_code="",
            string search="",
            string limit="",
            string offset="")
        {
            var url = BaseUrl + "/agencies";
            var response = await url
                .SetQueryParams(new {
                    featured = featured,
                    agency_type = agency_type,
                    country_code = country_code,
                    search = search,
                    limit = limit,
                    offset = offset})
                .GetJsonAsync<Agencies>();

           // var agencies = JsonConvert.DeserializeObject<Agencies>(response.Content.ToString());

            return response;
        }

        public async Task<Agency> GetAgencyById(string id)
        {
            var url = BaseUrl + "/agencies/" + id;
            var response = await url.GetJsonAsync<Agency>();
            //var agency = JsonConvert.DeserializeObject<Agency>(response.Content.ToString());

            return response;
        }
    }
}
