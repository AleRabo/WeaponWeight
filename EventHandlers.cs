using Exiled.Events.EventArgs;
using Exiled.API.Extensions;

namespace WeaponWeight
{
    public class EventHandlers
    {
        public void ChangingItem(ChangingItemEventArgs ev)
        {
            switch (ev.NewItem.id)
            {
                case ItemType.GunLogicer:
                    ev.Player.ChangeWalkingSpeed(Plugin.WeaponWeight.Config.LogicerWalkSpeed);ev.Player.ChangeRunningSpeed(Plugin.WeaponWeight.Config.LogicerRunSpeed); 
                    break;
                case ItemType.GunProject90:
                    ev.Player.ChangeWalkingSpeed(Plugin.WeaponWeight.Config.Project90WalkSpeed);ev.Player.ChangeRunningSpeed(Plugin.WeaponWeight.Config.Project90RunSpeed); 
                    break;
                case ItemType.GunE11SR:
                    ev.Player.ChangeWalkingSpeed(Plugin.WeaponWeight.Config.E11SRWalkSpeed);ev.Player.ChangeRunningSpeed(Plugin.WeaponWeight.Config.E11SRRunSpeed);
                    break;
                case ItemType.GunUSP:
                    ev.Player.ChangeWalkingSpeed(Plugin.WeaponWeight.Config.USPWalkSpeed);ev.Player.ChangeRunningSpeed(Plugin.WeaponWeight.Config.USPRunSpeed);
                    break;
                case ItemType.GunMP7:
                    ev.Player.ChangeWalkingSpeed(Plugin.WeaponWeight.Config.Mp7WalkSpeed);ev.Player.ChangeRunningSpeed(Plugin.WeaponWeight.Config.Mp7RunSpeed);
                    break;
                case ItemType.MicroHID:
                    ev.Player.ChangeWalkingSpeed(Plugin.WeaponWeight.Config.MicroHIDWalkSpeed);ev.Player.ChangeRunningSpeed(Plugin.WeaponWeight.Config.MicroHIDRunSpeed);
                    break;
                case ItemType.GunCOM15:
                    ev.Player.ChangeWalkingSpeed(Plugin.WeaponWeight.Config.Com15WalkSpeed);ev.Player.ChangeRunningSpeed(Plugin.WeaponWeight.Config.Com15RunSpeed);
                    break;
            }

            if (!ev.NewItem.id.IsWeapon() && ev.NewItem.id != ItemType.MicroHID && ev.NewItem.id == ItemType.None)
            {
                ev.Player.ChangeWalkingSpeed(1f);
                ev.Player.ChangeRunningSpeed(1f);
            }
        }
    }
} 
