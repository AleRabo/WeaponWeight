using Exiled.Events.EventArgs;
using Exiled.API.Extensions;
using itemType = Exiled.API.Enums.ItemType;

namespace WeaponWeight
{
    public class EventHandlers
    {
        public void ChangingItem(ChangingItemEventArgs ev)
        {
            if (!ev.NewItem.Type.IsWeapon() && ev.NewItem.Type != itemType.MicroHid)
            {
                ev.Player.ChangeWalkingSpeed(1f);
                ev.Player.ChangeRunningSpeed(1f);
            }

            switch (ev.NewItem.Type)
            {
                case itemType.GunLogicer:
                    ev.Player.ChangeWalkingSpeed(Plugin.WeaponWeight.Config.LogicerWalkSpeed);ev.Player.ChangeRunningSpeed(Plugin.WeaponWeight.Config.LogicerRunSpeed); 
                    break;
                case itemType.GunCrossvec:
                    ev.Player.ChangeWalkingSpeed(Plugin.WeaponWeight.Config.Project90WalkSpeed);ev.Player.ChangeRunningSpeed(Plugin.WeaponWeight.Config.Project90RunSpeed); 
                    break;
                case itemType.GunE11Sr:
                    ev.Player.ChangeWalkingSpeed(Plugin.WeaponWeight.Config.E11SRWalkSpeed);ev.Player.ChangeRunningSpeed(Plugin.WeaponWeight.Config.E11SRRunSpeed);
                    break;
                case itemType.GunCom18:
                    ev.Player.ChangeWalkingSpeed(Plugin.WeaponWeight.Config.USPWalkSpeed);ev.Player.ChangeRunningSpeed(Plugin.WeaponWeight.Config.USPRunSpeed);
                    break;
                case itemType.GunFsp9:
                    ev.Player.ChangeWalkingSpeed(Plugin.WeaponWeight.Config.FSP9WalkSpeed);ev.Player.ChangeRunningSpeed(Plugin.WeaponWeight.Config.FSP9RunSpeed);
                    break;
                case itemType.MicroHid:
                    ev.Player.ChangeWalkingSpeed(Plugin.WeaponWeight.Config.MicroHIDWalkSpeed);ev.Player.ChangeRunningSpeed(Plugin.WeaponWeight.Config.MicroHIDRunSpeed);
                    break;
                case itemType.GunCom15:
                    ev.Player.ChangeWalkingSpeed(Plugin.WeaponWeight.Config.Com15WalkSpeed);ev.Player.ChangeRunningSpeed(Plugin.WeaponWeight.Config.Com15RunSpeed);
                    break;
                case itemType.GunAk:
                    ev.Player.ChangeWalkingSpeed(Plugin.WeaponWeight.Config.AKWalkSpeed); ev.Player.ChangeRunningSpeed(Plugin.WeaponWeight.Config.AKRunSpeed);
                    break;
                case itemType.GunRevolver:
                    ev.Player.ChangeWalkingSpeed(Plugin.WeaponWeight.Config.RevolverWalkSpeed); ev.Player.ChangeRunningSpeed(Plugin.WeaponWeight.Config.RevolverRunSpeed);
                    break;
                case itemType.GunShotgun:
                    ev.Player.ChangeWalkingSpeed(Plugin.WeaponWeight.Config.ShotGunWalkSpeed); ev.Player.ChangeRunningSpeed(Plugin.WeaponWeight.Config.ShotGunRunSpeed);
                    break;
                   
            }
        }
    }
} 
