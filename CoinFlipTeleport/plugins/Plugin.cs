using Exiled.API.Features;
using System;
using Exiled.API.Extensions;
using Exiled.API.Features.Items;
using Exiled.Events.Commands.Reload;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.Features;

namespace CoinFlipTeleport
{
    public class Plugin : Plugin<Config>
    {
        public Config _Config;
        public override Version Version => new Version(4, 5, 0);
        public override string Author => "Akinasu333";
        public override string Name => "CoinFlipTeleport";

        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.FlippingCoin += Flipper;
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.FlippingCoin -= Flipper;
        }
        public void Flipper(FlippingCoinEventArgs ev)
        {
            if (Warhead.IsDetonated)
            {
                Scp330 candy = (Scp330)Item.Create(ItemType.SCP330);
                candy.AddCandy(InventorySystem.Items.Usables.Scp330.CandyKindID.Red);
                ev.Player.AddItem(candy);
                ev.Item.Destroy();
                return;
            }
            else
            {
                Room randomRoom = Room.Get(_Config.RoomsToTeleport.GetRandomValue());
                ev.Player.Teleport(randomRoom.Position);
                ev.Item.Destroy();
            }
        }
    }

}
