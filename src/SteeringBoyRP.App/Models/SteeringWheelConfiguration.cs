using System;

namespace SteeringBoyRP.App.Models
{
    [Serializable]
    public class SteeringWheelConfiguration
    {
        public required string WheelImageSourceUri { get; set; }
        public required string HandImageSourceUri { get; set; }
        public required string SirenImageSourceUri { get; set; }
        public bool IsLeftHandEnabled { get; set; }
        public bool IsRightHandEnabled { get; set; }
        public bool IsSirenEnabled { get; set; }
    }
}
