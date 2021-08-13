using Exiled.Events.EventArgs;
using Exiled.API.Extensions;

namespace WeaponWeight
{
    public class EventHandlers
    {
        public void OnChangingItem(ChangingItemEventArgs ev)
        {
            if (ev.NewItem.id == ItemType.GunLogicer)
            {
                ev.Player.ChangeWalkingSpeed(Plugin.Singleton.Config.LogicerWalkSpeed);
                ev.Player.ChangeRunningSpeed(Plugin.Singleton.Config.LogicerRunSpeed);
            }

            else if (ev.NewItem.id == ItemType.GunProject90)
            {
                ev.Player.ChangeWalkingSpeed(Plugin.Singleton.Config.Project90WalkSpeed);
                ev.Player.ChangeRunningSpeed(Plugin.Singleton.Config.Project90RunSpeed);
            }

            else if (ev.NewItem.id == ItemType.GunMP7)
            {
                ev.Player.ChangeWalkingSpeed(Plugin.Singleton.Config.Mp7WalkSpeed);
                ev.Player.ChangeRunningSpeed(Plugin.Singleton.Config.Mp7RunSpeed);
            }

            else if (ev.NewItem.id == ItemType.GunE11SR)
            {
                ev.Player.ChangeWalkingSpeed(Plugin.Singleton.Config.E11SRWalkSpeed);
                ev.Player.ChangeRunningSpeed(Plugin.Singleton.Config.E11SRRunSpeed);
            }

            else if (ev.NewItem.id == ItemType.GunUSP)
            {
                ev.Player.ChangeWalkingSpeed(Plugin.Singleton.Config.USPWalkSpeed);
                ev.Player.ChangeRunningSpeed(Plugin.Singleton.Config.USPRunSpeed);
            }

            else if (ev.NewItem.id == ItemType.GunCOM15)
            {
                ev.Player.ChangeWalkingSpeed(Plugin.Singleton.Config.Com15WalkSpeed);
                ev.Player.ChangeRunningSpeed(Plugin.Singleton.Config.Com15RunSpeed);
            }

            else if (ev.NewItem.id == ItemType.MicroHID)
            {
                ev.Player.ChangeWalkingSpeed(Plugin.Singleton.Config.MicroHIDWalkSpeed);
                ev.Player.ChangeRunningSpeed(Plugin.Singleton.Config.MicroHIDRunSpeed);
            }

            if (ev.NewItem.id != ItemType.GunLogicer && ev.NewItem.id != ItemType.GunProject90 && ev.NewItem.id != ItemType.MicroHID && ev.NewItem.id != ItemType.GunE11SR && ev.NewItem.id != ItemType.GunUSP && ev.NewItem.id != ItemType.GunCOM15 && ev.NewItem.id != ItemType.MicroHID && ev.NewItem.id != ItemType.GunMP7)
            {
                ev.Player.ChangeWalkingSpeed(1f);
                ev.Player.ChangeRunningSpeed(1f);
            }
        }
    }
}