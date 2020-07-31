using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibraryNET.Models
{
    public class DockingEvents
    {
        public long Count { get; set; }
        public Uri Next { get; set; }
        public object Previous { get; set; }
        public DockingEventsResult[] Results { get; set; }
    }

    public class DockingEventsResult
    {
        public int Id { get; set; }
        public Uri Url { get; set; }
        public string LaunchId { get; set; }
        public DateTimeOffset Docking { get; set; }
        public DateTimeOffset Departure { get; set; }
        public DockingEventsFlightVehicle FlightVehicle { get; set; }
        public DockingEventsDockingLocation DockingLocation { get; set; }
    }

    public class DockingEventsDockingLocation
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class DockingEventsFlightVehicle
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Destination { get; set; }
        public DateTimeOffset MissionEnd { get; set; }
        public DockingEventsSpacecraft Spacecraft { get; set; }
    }

    public class DockingEventsSpacecraft
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public DockingEventsDockingLocation Status { get; set; }
        public string Description { get; set; }
        public DockingEventsSpacecraftConfig SpacecraftConfig { get; set; }
    }

    public class DockingEventsSpacecraftConfig
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public DockingEventsDockingLocation Type { get; set; }
        public DockingEventsAgency Agency { get; set; }
        public bool InUse { get; set; }
        public Uri ImageUrl { get; set; }
    }

    public class DockingEventsAgency
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
