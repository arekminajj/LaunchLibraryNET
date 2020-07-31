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

        public async Task<Events> GetEvents(
            string slug = "",
            string id = "",
            string type = "",
            string search = "",
            string limit = "",
            string offset = ""
           )
        {
            var url = BaseUrl + "/event";
            var events = await url
                .SetQueryParams(new
                {
                    slug = slug,
                    id = id,
                    type = type,
                    search = search,
                    limit = limit,
                    offset = offset
                })
                .GetJsonAsync<Events>();

            return events;
        }

        public async Task<Event> GetEventById(string id)
        {
            var url = BaseUrl + "/event/" + id;
            var _event = await url.GetJsonAsync<Event>();

            return _event;
        }

        public async Task<DockingEvents> GetDockingEvents(
            string space_station__id = "",
            string docking_location__id = "",
            string flight_vehicle__id = "",
            string docking__gt = "",
            string docking__lt = "",
            string docking__gte = "",
            string docking__lte = "",
            string search = "",
            string ordering = "",
            string limit = "",
            string offset = ""
        )
        {
            var url = BaseUrl + "/docking_event";
            var dockingEvents = await url
                .SetQueryParams(new
                {
                    space_station__id = space_station__id,
                    idocking_location__idd = docking_location__id,
                    flight_vehicle__id = flight_vehicle__id,
                    docking__gt = docking__gt,
                    docking__lt = docking__lt,
                    docking__gte = docking__gte,
                    docking__lte = docking__lte,
                    search = search,
                    ordering = ordering,
                    limit = limit,
                    offset = offset
                })
                .GetJsonAsync<DockingEvents>();

            return dockingEvents;
        }

        public async Task<DockingEvent> GetDockingEventById(string id)
        {
            var url = BaseUrl + "/docking_event/" + id;
            var dockingEvent = await url.GetJsonAsync<DockingEvent>();

            return dockingEvent;
        }

        public async Task<Expeditions> GetExpeditions(
            string name = "",
            string dockincrew__astronautg_location__id = "",
            string crew__astronaut__agency = "",
            string space_station = "",
            string start__gt = "",
            string start__lt = "",
            string start__gte = "",
            string start__lte = "",
            string end__gt = "",
            string end__lt = "",
            string end__gte = "",
            string end__lte = "",
            string search = "",
            string ordering = "",
            string limit = "",
            string offset = ""
        )
        {
            var url = BaseUrl + "/expedition";
            var expeditions = await url
                .SetQueryParams(new
                {
                    name = name,
                    dockincrew__astronautg_location__id = dockincrew__astronautg_location__id,
                    start__lt = start__lt,
                    crew__astronaut__agency = crew__astronaut__agency,
                    space_station = space_station,
                    start__gt = start__gt,
                    start__gte = start__gte,
                    start__lte = start__lte,
                    end__gt = end__gt,
                    end__ltit = end__lt,
                    end__gte = end__gte,
                    end__lte = end__lte,
                    search = search,
                    ordering = ordering,
                    limit = limit,
                    offset = offset
                })
                .GetJsonAsync<Expeditions>();

            return expeditions;
        }

        public async Task<Expedition> GetExpeditionById(string id)
        {
            var url = BaseUrl + "/expedition/" + id;
            var expedition = await url.GetJsonAsync<Expedition>();

            return expedition;
        }
    }
}
