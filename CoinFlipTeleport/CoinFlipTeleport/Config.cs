// Decompiled with JetBrains decompiler
// Type: CoinFlipTeleport.Config
// Assembly: NoTrollBombs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 74BF47E9-8C35-4DDA-905B-C26415F827F8
// Assembly location: C:\Users\user\AppData\Local\Temp\tmp-33740-d42la7NR9er9\CoinFlipTeleport.dll

using Exiled.API.Interfaces;

namespace CoinFlipTeleport
{
  public class Config : IConfig
  {
    public bool IsEnabled { get; set; } = true;

    public bool Debug { get; set; } = false;
  }
}
