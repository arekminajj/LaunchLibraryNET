using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibraryNET.Models
{
    public class DockingEvent
    {
        public int Id { get; set; }
        public Uri Url { get; set; }
        public Guid LaunchId { get; set; }
        public DateTimeOffset Docking { get; set; }
        public DateTimeOffset Departure { get; set; }
        public DockingEventFlightVehicle FlightVehicle { get; set; }
        public DockingEventDockingLocation DockingLocation { get; set; }
        public DockingEventSpaceStation SpaceStation { get; set; }
    }

    public class DockingEventDockingLocation
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class DockingEventFlightVehicle
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Destination { get; set; }
        public DateTimeOffset MissionEnd { get; set; }
        public DockingEventSpacecraft Spacecraft { get; set; }
    }

    public class DockingEventSpacecraft
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public DockingEventDockingLocation Status { get; set; }
        public string Description { get; set; }
        public DockingEventSpacecraftConfig SpacecraftConfig { get; set; }
    }

    public class DockingEventSpacecraftConfig
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public DockingEventDockingLocation Type { get; set; }
        public DockingEventAgency Agency { get; set; }
        public bool InUse { get; set; }
        public string Capability { get; set; }
        public string History { get; set; }
        public string Details { get; set; }
        public DateTimeOffset MaidenFlight { get; set; }
        public object Height { get; set; }
        public object Diameter { get; set; }
        public bool HumanRated { get; set; }
        public long CrewCapacity { get; set; }
        public object PayloadCapacity { get; set; }
        public string FlightLife { get; set; }
        public Uri ImageUrl { get; set; }
        public object NationUrl { get; set; }
        public Uri WikiLink { get; set; }
        public string InfoLink { get; set; }
    }

    public class DockingEventAgency
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public bool Featured { get; set; }
        public string Type { get; set; }
        public string CountryCode { get; set; }
        public string Abbrev { get; set; }
        public string Description { get; set; }
        public string Administrator { get; set; }
        public long FoundingYear { get; set; }
        public string Launchers { get; set; }
        public string Spacecraft { get; set; }
        public object Parent { get; set; }
        public Uri ImageUrl { get; set; }
    }

    public class DockingEventSpaceStation
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public Uri ImageUrl { get; set; }
    }
}
