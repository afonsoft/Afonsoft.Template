// Decompiled with JetBrains decompiler
// Type: Abp.AspNetZeroCore.Timing.AppTimes
// Assembly: Abp.AspNetZeroCore, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C04A4B48-ACC3-437A-A98E-0541F047878B
// Assembly location: C:\Portal-Afonsoft\nuget\abp.aspnetzerocore\2.0.0\lib\netcoreapp3.0\Abp.AspNetZeroCore.dll

using Abp.Dependency;
using System;

namespace Abp.AspNetZeroCore.Timing
{
  public class AppTimes : ISingletonDependency
  {
    public DateTime StartupTime { get; set; }
  }
}
