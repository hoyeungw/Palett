﻿using System.Diagnostics;
using NUnit.Framework;
using Spare;
using Veho.Sequence;

namespace Palett.Test.Munsell {
  [TestFixture]
  public partial class MunsellTests {
    [Test]
    public void RhodoneaFoliosTest() {
      Debug.Print($">> [HSL] {Hsl}");
      var list = Hsl.RhodoneaFolios(5, Density, LightMinimum, SaturTolerance, Domain.Fashion);
      list
        .Map(x => $"\n{x.hex}: {Dyer.Render(x.hex, x.name)} ({Conv.HexToHsl(x.hex)})")
        .Deco()
        .Logger();
    }

    [Test]
    public void AnalogousTest() {
      Debug.Print($">> [HSL] {Hsl}");
      var list = Hsl.Analogous(-30, 12);
      list
        .Map(x => $"\n{x.hex}: {Dyer.Render(x.hex, x.name)} ({Conv.HexToHsl(x.hex)})")
        .Deco()
        .Logger();
    }
  }
}