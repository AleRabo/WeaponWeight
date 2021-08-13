using Exiled.API.Interfaces;
using System.ComponentModel;

namespace WeaponWeight
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("The walking speed when a player have equiped the Logicer")]
        public float LogicerWalkSpeed { get; set; } = 0.6f;

        [Description("The running speed when a player have equiped the Logicer")]
        public float LogicerRunSpeed { get; set; } = 0.8f;

        [Description("The walking speed when a player have equiped the Project 90")]
        public float Project90WalkSpeed { get; set; } = 0.95f;

        [Description("The running speed when a player have equiped the Project 90")]
        public float Project90RunSpeed { get; set; } = 1f;

        [Description("The walking speed when a player have equiped the MTF E11SR")]
        public float E11SRWalkSpeed { get; set; } = 0.86f;

        [Description("The running speed when a player have equiped the MTF E11SR")]
        public float E11SRRunSpeed { get; set; } = 0.96f;

        [Description("The walking speed when a player have equiped the USP")]
        public float USPWalkSpeed { get; set; } = 0.75f;

        [Description("The running speed when a player have equiped the USP")]
        public float USPRunSpeed { get; set; } = 0.85f;

        [Description("The walking speed when a player have equiped the Com-15")]
        public float Com15WalkSpeed { get; set; } = 0.95f;

        [Description("The running speed when a player have equiped the Com-15")]
        public float Com15RunSpeed { get; set; } = 1f;

        [Description("The walking speed when a player have equiped the Micro HID")]
        public float MicroHIDWalkSpeed { get; set; } = 0.54f;

        [Description("The running speed when a player have equiped the Micro HID")]
        public float MicroHIDRunSpeed { get; set; } = 0.7f;

        [Description("The walking speed when a player have equiped the Micro HID")]
        public float Mp7WalkSpeed { get; set; } = 0.54f;

        [Description("The running speed when a player have equiped the Micro HID")]
        public float Mp7RunSpeed { get; set; } = 0.7f;

    }
}
