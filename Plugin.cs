using Exiled.API.Features;
using System;
using PlayerHandlers = Exiled.Events.Handlers.Player;

namespace WeaponWeight
{
    public class Plugin : Plugin<Config>
    {

        // The singleton of the plugin
        public static Plugin Singleton;


        public override string Prefix => "WeaponWeight";


        public override Version RequiredExiledVersion { get; } = new Version(2, 8, 0);

        private EventHandlers EventHandlers;

        public override void OnEnabled()
        {
            Singleton = this;
            EventHandlers = new EventHandlers();


            PlayerHandlers.ChangingItem += EventHandlers.OnChangingItem;


            base.OnEnabled();
        }

        public override void OnDisabled()
        {

            PlayerHandlers.ChangingItem -= EventHandlers.OnChangingItem;

            EventHandlers = null;
            Singleton = null;
            base.OnDisabled();
        }
    }
}

