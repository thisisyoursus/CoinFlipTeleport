using Exiled.API.Enums;
using System.Collections.Generic;
using Exiled.API.Interfaces;

namespace CoinFlipTeleport
{
  public class Config : IConfig
  {
    public bool IsEnabled { get; set; } = true;

    public bool Debug { get; set; } = false;

        public HashSet<RoomType> RoomsToTeleport { get; set; } = new HashSet<RoomType>()
        {
            RoomType.EzCafeteria,
            RoomType.EzCheckpointHallway,
            RoomType.EzConference,
            RoomType.EzCrossing,
            RoomType.EzCurve,
            RoomType.EzDownstairsPcs,
            RoomType.EzGateA,
            RoomType.EzGateB,
            RoomType.EzIntercom,
            RoomType.EzPcs,
            RoomType.EzStraight,
            RoomType.EzTCross,
            RoomType.EzUpstairsPcs,
            RoomType.EzVent,
            RoomType.Hcz049,
            RoomType.Hcz079,
            RoomType.Hcz096,
            RoomType.Hcz106,
            RoomType.Hcz939,
            RoomType.HczArmory,
            RoomType.HczCrossing,
            RoomType.HczCurve,
            RoomType.HczElevatorA,
            RoomType.HczElevatorB,
            RoomType.HczEzCheckpointA,
            RoomType.HczEzCheckpointB,
            RoomType.HczHid,
            RoomType.HczNuke,
            RoomType.HczServers,
            RoomType.HczStraight,
            RoomType.HczTCross,
            RoomType.HczTesla,
            RoomType.HczTestRoom,
            RoomType.Lcz330,
            RoomType.Lcz914,
            RoomType.LczAirlock,
            RoomType.LczArmory,
            RoomType.LczCafe,
            RoomType.LczCheckpointA,
            RoomType.LczCheckpointB,
            RoomType.LczClassDSpawn,
            RoomType.LczCrossing,
            RoomType.LczCurve,
            RoomType.LczGlassBox,
            RoomType.LczPlants,
            RoomType.LczStraight,
            RoomType.LczTCross,
            RoomType.LczToilets,
            RoomType.Surface,
        };
        [Description("When Lcz locked，can be teleport into Lcz")]
        public bool CanTeleportIntoLockedLCZ { get; set; } = false;
    }
}
