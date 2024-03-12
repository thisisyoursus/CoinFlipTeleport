using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;


#nullable enable
namespace NoTrollBombs
{
  internal class EventHandlers
  {
    public void flipper(FlippingCoinEventArgs ev)
    {
      ev.Player.RandomTeleport(typeof (Room));
      ev.Item.Destroy();
    }
  }
}
