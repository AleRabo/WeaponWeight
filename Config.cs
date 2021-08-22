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

        [Description("The walking speed when a player have equiped the Cross Vec")]
        public float Project90WalkSpeed { get; set; } = 0.95f;

        [Description("The running speed when a player have equiped the Cross Vec")]
        public float Project90RunSpeed { get; set; } = 1f;

        [Description("The walking speed when a player have equiped the MTF E11SR")]
        public float E11SRWalkSpeed { get; set; } = 0.86f;

        [Description("The running speed when a player have equiped the MTF E11SR")]
        public float E11SRRunSpeed { get; set; } = 0.96f;

        [Description("The walking speed when a player have equiped the GunCOM18")]
        public float USPWalkSpeed { get; set; } = 0.75f;

        [Description("The running speed when a player have equiped the GunCOM18")]
        public float USPRunSpeed { get; set; } = 0.85f;

        [Description("The walking speed when a player have equiped the Com-15")]
        public float Com15WalkSpeed { get; set; } = 0.95f;

        [Description("The running speed when a player have equiped the Com-15")]
        public float Com15RunSpeed { get; set; } = 1f;

        [Description("The walking speed when a player have equiped the Micro HID")]
        public float MicroHIDWalkSpeed { get; set; } = 0.54f;

        [Description("The running speed when a player have equiped the Micro HID")]
        public float MicroHIDRunSpeed { get; set; } = 0.7f;

        [Description("The walking speed when a player have equiped the Mp7")]
        public float FSP9WalkSpeed { get; set; } = 0.54f;

        [Description("The running speed when a player have equiped the FSP9")]
        public float FSP9RunSpeed { get; set; } = 0.7f;

        [Description("The running speed when a player have equiped the AK")]
        public float AKWalkSpeed { get; set; } = 0.7f;

        [Description("The running speed when a player have equiped the AK")]
        public float AKRunSpeed { get; set; } = 0.6f;

        [Description("The running speed when a player have equiped the Revolver")]
        public float RevolverWalkSpeed { get; set; } = 0.9f;

        [Description("The running speed when a player have equiped the Revolver")]
        public float RevolverRunSpeed { get; set; } = 0.8f;

        [Description("The running speed when a player have equiped the ShotGun")]
        public float ShotGunWalkSpeed { get; set; } = 0.8f;

        [Description("The running speed when a player have equiped the ShotGun")]
        public float ShotGunRunSpeed { get; set; } = 0.6f;
    }
}
