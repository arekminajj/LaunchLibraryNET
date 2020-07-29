using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaunchLibraryNET;
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
        public void AgencyIdShouldEqual270()
        {
            var agency = client.GetAgencyById("270");
            var id = agency.Result.id;
            Assert.Equal("270", id.ToString());
        }

    }
}
