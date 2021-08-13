using Exiled.API.Features;
using System;
using PlayerHandlers = Exiled.Events.Handlers.Player;

namespace WeaponWeight
{
    public class Plugin : Plugin<Config>
    {
        // The singleton of the plugin
        public static Plugin WeaponWeight;
            
        public override string Prefix => "WeaponWeight";

        public override Version RequiredExiledVersion { get; } = new Version(2, 11, 0);

        private EventHandlers EventHandlers;

        public override void OnEnabled()
        {
            EventHandlers = new EventHandlers();

            PlayerHandlers.ChangingItem += EventHandlers.ChangingItem;

            WeaponWeight = this;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {

            PlayerHandlers.ChangingItem -= EventHandlers.ChangingItem;

            EventHandlers = null;
         
            base.OnDisabled();
        }
    }
}
