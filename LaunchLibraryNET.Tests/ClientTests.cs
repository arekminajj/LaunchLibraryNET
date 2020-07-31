using Xunit;

namespace LaunchLibraryNET.Tests
{
    public class ClientTests
    {
        private Client client = new Client();

        [Fact]
        public void AgenciesShouldNotBeNull()
        {
            Assert.NotNull(client.GetAgencies().Result);
        }

        [Fact]
        public void SearchedAgencyNameShouldEqualItsName()
        {
            var filteredAgencies = client.GetAgencies(search: "Aerojet");
            var agencyName = filteredAgencies.Result.results[0].name;
            Assert.Equal("Aerojet", agencyName);
        }

        [Fact]
        public void AgencyIdShouldEqual270()
        {
            var agency = client.GetAgencyById("270");
            var id = agency.Result.id;
            Assert.Equal("270", id.ToString());
        }

        [Fact]
        public void AgencyNameShouldEqualItsName()
        {
            var agency = client.GetAgencyById("225"); //1worldspace
            var name = agency.Result.name;
            Assert.Equal("1worldspace", name);
        }

        [Fact]
        public void AstronautsDateOfBirthShouldMatchHesName()
        {
            var searched_astronaut = client.GetAstronauts(date_of_birth: "1941-09-15");
            var name = searched_astronaut.Result.results[0].name;

            Assert.Equal("Mirosław Hermaszewski", name);
        }

        [Fact]
        public void AstronautIdShouldEqualHesName()
        {
            var astronaut = client.GetAstronautById("136");
            var name = astronaut.Result.Name;

            Assert.Equal("Mirosław Hermaszewski", name);
        }

        [Fact]
        public void SearchedLauncherConfigNameShouldEqualItsName()
        {
            var launcherConfig = client.GetLauncherConfigs(search: "Angara-1.2pp");
            var name = launcherConfig.Result.Results[0].Name;

            Assert.Equal("Angara-1.2pp", name);
        }

        [Fact]
        public void LauncherConfigsIdShouldMatchItsName()
        {
            var launcherConfig = client.GetLauncherConfigById("53");
            var name = launcherConfig.Result.Name;

            Assert.Equal("Angara-1.2pp", name);
        }

        [Fact]
        public void SearchedSpacecraftConfigsNameShouldMatchId()
        {
            var searchedSpacecraftConfig = client.GetSpacecraftConfigs(search: "cst-100");
            var id = searchedSpacecraftConfig.Result.Results[0].Id;

            Assert.Equal(9,id);
        }

        [Fact]
        public void SpacecraftConfigsNameShouldEqualItsName()
        {
            var spacecraftConfig = client.GetSpacecraftConfigById("9");
            var name = spacecraftConfig.Result.Name;

            Assert.Equal("CST-100 Starliner", name);
        }

        [Fact]
        public void EventIdShouldMatchItsName()
        {
            var astroEvent = client.GetEvents(search: "70th");
            var id = astroEvent.Result.Results[0].Id;

            Assert.Equal(60, id);
        }

        [Fact]
        public void EventIdShouldEqualItsId()
        {
            var astroEvent = client.GetEventById("60");
            var id = astroEvent.Result.Id;

            Assert.Equal(60, id);
        }

        [Fact]
        public void SearchedDockingEventIdShouldMatchItsUrl()
        {
            var dockingEvents = client.GetDockingEvents(flight_vehicle__id: "220");
            var launchUrl = dockingEvents.Result.Results[0].Url;

            Assert.Equal("https://lldev.thespacedevs.com/2.0.0/docking_event/100/", launchUrl.ToString());
        }

        [Fact]
        public void DockingEventIdShouldEqualItsId()
        {
            var dockingEvent = client.GetDockingEventById("100");
            var id = dockingEvent.Result.Id;

            Assert.Equal(100, id);
        }
    }
}
