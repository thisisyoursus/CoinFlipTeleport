// Decompiled with JetBrains decompiler
// Type: NoTrollBombs.EventHandlers
// Assembly: NoTrollBombs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 74BF47E9-8C35-4DDA-905B-C26415F827F8
// Assembly location: C:\Users\user\AppData\Local\Temp\tmp-33740-d42la7NR9er9\CoinFlipTeleport.dll

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
