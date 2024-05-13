using System;

namespace SteeringBoyRP.App.Models
{
    [Serializable]
    public class SteeringWheelConfiguration
    {
        public required string WheelImageSourceUri { get; set; }
        public required string HandImageSourceUri { get; set; }

        public bool IsWheelEnabled { get; set; }
        public bool IsLeftHandEnabled { get; set; }
        public bool IsRightHandEnabled { get; set; }

        public int WheelSizePx { get; set; }
        public int HandSizePx { get; set; }

        public double LeftHandLocationX { get; set; }
        public double LeftHandLocationY { get; set; }
        public double RightHandLocationX { get; set; }
        public double RightHandLocationY { get; set; }
    }
}
