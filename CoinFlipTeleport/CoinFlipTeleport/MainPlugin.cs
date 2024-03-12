using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.Features;
using NoTrollBombs;


#nullable enable
namespace CoinFlipTeleport
{
  public class MainPlugin : Plugin<Config>
  {
    private EventHandlers _handler = new EventHandlers();

    public virtual void OnEnabled()
    {
      Exiled.Events.Handlers.Player.FlippingCoin += new CustomEventHandler<FlippingCoinEventArgs>(this._handler.flipper);
      base.OnEnabled();
    }

    public virtual void OnDisabled()
    {
      Exiled.Events.Handlers.Player.FlippingCoin -= new CustomEventHandler<FlippingCoinEventArgs>(this._handler.flipper);
      base.OnDisabled();
    }
  }
}
