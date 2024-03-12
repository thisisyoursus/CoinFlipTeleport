// Decompiled with JetBrains decompiler
// Type: CoinFlipTeleport.MainPlugin
// Assembly: NoTrollBombs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 74BF47E9-8C35-4DDA-905B-C26415F827F8
// Assembly location: C:\Users\user\AppData\Local\Temp\tmp-33740-d42la7NR9er9\CoinFlipTeleport.dll

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
