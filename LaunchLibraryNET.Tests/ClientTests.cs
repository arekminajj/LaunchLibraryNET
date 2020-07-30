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

    }
}
