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
        public Config _Config = new Config();
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
            if (ev.Player == null)
            {
                Exiled.API.Features.Log.Error("Flipper method received a null player reference.");
                return;
            }
            if ( Warhead.IsDetonated)
            {
                Scp330 candy = (Scp330)Item.Create(ItemType.SCP330);
                candy.AddCandy(InventorySystem.Items.Usables.Scp330.CandyKindID.Red);
                ev.Player.AddItem(candy);
                ev.Item.Destroy();
                return;
            }
            else
            {
                
                ev.Player.Teleport(Room.Get(_Config.RoomsToTeleport.GetRandomValue()));
                ev.Item.Destroy();
            }

            if(Map.DecontaminationState == DecontaminationState.Lockdown || Map.DecontaminationState == DecontaminationState.Countdown || Map.DecontaminationState == DecontaminationState.Remain1Minute)
            {
                if (_Config.CanTeleportIntoLockedLCZ)
                {
                    ev.Player.Teleport(Room.Get(_Config.RoomsToTeleport.GetRandomValue()));
                    ev.Item.Destroy();
                }
                else
                {
                    var nonLczRooms = _Config.RoomsToTeleport.Where(room => !IsLczRoom(room)).ToList();
                    ev.Player.Teleport(Room.Get(nonLczRooms.GetRandomValue()));
                    ev.Item.Destroy();
                }
            }

        }
        bool IsLczRoom(RoomType room)
        {

            return room == RoomType.Lcz173 ||
                   room == RoomType.Lcz330 ||
                   room == RoomType.Lcz914 ||
                   room == RoomType.LczAirlock ||
                   room == RoomType.LczArmory ||
                   room == RoomType.LczCafe ||
                   room == RoomType.LczCheckpointA ||
                   room == RoomType.LczCheckpointB ||
                   room == RoomType.LczClassDSpawn ||
                   room == RoomType.LczCrossing ||
                   room == RoomType.LczCurve ||
                   room == RoomType.LczGlassBox ||
                   room == RoomType.LczPlants ||
                   room == RoomType.LczStraight ||
                   room == RoomType.LczTCross ||
                   room == RoomType.LczToilets;
        }
    }


}
