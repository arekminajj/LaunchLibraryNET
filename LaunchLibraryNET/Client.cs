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
            _apiKey = "";
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
            var agencies = await url
                .SetQueryParams(new {
                    featured = featured,
                    agency_type = agency_type,
                    country_code = country_code,
                    search = search,
                    limit = limit,
                    offset = offset})
                .GetJsonAsync<Agencies>();

            return agencies;
        }

        public async Task<Agency> GetAgencyById(string id)
        {
            var url = BaseUrl + "/agencies/" + id;
            var agency = await url.GetJsonAsync<Agency>();

            return agency;
        }

        public async Task<Astronauts> GetAstronauts(
            string agency__name = "",
            string date_of_death = "",
            string name = "",
            string nationality = "",
            string date_of_birth = "",
            string agency__abbrev = "",
            string status = "",
            string date_of_birth__gt = "",
            string date_of_birth__lt = "",
            string date_of_birth__gte = "",
            string date_of_birth__lte = "",
            string date_of_death__gt = "",
            string date_of_death__lt = "",
            string date_of_death__gte = "",
            string date_of_death__lte = "",
            string search = "",
            string ordering = "",
            string limit = "",
            string offset = "")
        {
            var url = BaseUrl + "/astronaut";
            var astronauts = await url
                .SetQueryParams(new
                {
                    agency__name = agency__name,
                    date_of_birth = date_of_birth,
                    name = name,
                    nationality = nationality,
                    date_of_death = date_of_death,
                    agency__abbrev = agency__abbrev,
                    status = status,
                    date_of_birth__gt = date_of_birth__gt,
                    date_of_birth__lt = date_of_birth__lt,
                    date_of_birth__gte = date_of_birth__gte,
                    date_of_birth__lte = date_of_birth__lte,
                    date_of_death__gt = date_of_death__gt,
                    date_of_death__lt = date_of_death__lt,
                    date_of_death__gte = date_of_death__gte,
                    date_of_death__lte = date_of_death__lte,
                    search = search,
                    ordering = ordering,
                    limit = limit,
                    offset = offset
                })
                .GetJsonAsync<Astronauts>();

            return astronauts;
        }

        public async Task<Astronaut> GetAstronautById(string id)
        {
            var url = BaseUrl + "/astronaut/" + id;
            var astronaut = await url.GetJsonAsync<Astronaut>();

            return astronaut;
        }

        public async Task<LauncherConfigs> GetLauncherConfigs(
            string family = "",
            string name = "",
            string manufacturer = "",
            string full_name = "",
            string active = "",
            string reusable = "",
            string search = "",
            string ordering = "",
            string limit = "",
            string offset = "")
        {
            var url = BaseUrl + "/config/launcher";
            var launcherConfigs = await url
                .SetQueryParams(new
                {
                    family = family,
                    name = name,
                    manufacturer = manufacturer,
                    full_name = full_name,
                    active = active,
                    reusable = reusable,
                    search = search,
                    ordering = ordering,
                    limit = limit,
                    offset = offset
                })
                .GetJsonAsync<LauncherConfigs>();

            return launcherConfigs;
        }

        public async Task<LauncherConfig> GetLauncherConfigById(string id)
        {
            var url = BaseUrl + "/config/launcher/" + id;
            var launcherConfig = await url.GetJsonAsync<LauncherConfig>();

            return launcherConfig;
        }

        public async Task<SpacecraftConfigs> GetSpacecraftConfigs(
            string name = "",
            string manufacturer = "",
            string in_use = "",
            string human_rated = "",
            string search = "",
            string ordering = "",
            string limit = "",
            string offset = "")
        {
            var url = BaseUrl + "/config/spacecraft";
            var spacecraftConfigs = await url
                .SetQueryParams(new
                {
                    name = name,
                    manufacturer = manufacturer,
                    in_use = in_use,
                    human_rated = human_rated,
                    search = search,
                    ordering = ordering,
                    limit = limit,
                    offset = offset
                })
                .GetJsonAsync<SpacecraftConfigs>();

            return spacecraftConfigs;
        }

        public async Task<SpacecraftConfig> GetSpacecraftConfigById(string id)
        {
            var url = BaseUrl + "/config/spacecraft/" + id;
            var spacecraftConfig = await url.GetJsonAsync<SpacecraftConfig>();

            return spacecraftConfig;
        }
    }
}
