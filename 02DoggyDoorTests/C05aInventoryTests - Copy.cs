using C05a.Models;
using C05a.Enums;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace XXTests
{
    [TestClass]
    public class C05aInventoryTests
    {
        private readonly Inventory sampleInventory;

        public C05aInventoryTests()
        {
            sampleInventory = GetSampleInventory();
        }

        [TestMethod]
        public void InventoryHasEightInstruments()
        {
            Assert.AreEqual(8, sampleInventory.InventoryCount);
        }

        [TestMethod]
        public void TwoMatchesForErin()
        {
            GuitarSpec searchSpec = new GuitarSpec
            {
                Builder = Builder.Fender,
                ModelName = "Stratocaster",
                Type = GuitarType.Electric,
                TopWood = Wood.Alder,
                BackWood = Wood.Alder
            };
            var matchingGuitars = sampleInventory.Search(searchSpec);

            Assert.AreEqual(2, (matchingGuitars as List<Guitar>).Count);

            foreach(Guitar match in matchingGuitars)
            {
                Assert.AreEqual(match.Spec.Builder, searchSpec.Builder);
                Assert.IsTrue(match.Spec.ModelName.Equals(searchSpec.ModelName, StringComparison.OrdinalIgnoreCase));
                Assert.AreEqual(match.Spec.Type, searchSpec.Type);
                Assert.AreEqual(match.Spec.TopWood, searchSpec.TopWood);
                Assert.AreEqual(match.Spec.BackWood, searchSpec.BackWood);
            }
        }

        private Inventory GetSampleInventory()
        {
            Inventory i = new Inventory();

            i.AddInstrument(new Guitar("Apple", 199.99, new GuitarSpec{
                Builder = Builder.Fender,
                ModelName = "StratOcaster",
                Type = GuitarType.Electric,
                BackWood = Wood.Cedar,
                TopWood = Wood.Cedar
            }));
            i.AddInstrument(new Guitar("Banana", 250.55, new GuitarSpec
            {
                Builder = Builder.Fender,
                ModelName = "stratocaster",
                Type = GuitarType.Electric,
                BackWood = Wood.Alder,
                TopWood = Wood.Alder
            }));
            i.AddInstrument(new Guitar("Coconut", 15.99, new GuitarSpec
            {
                Builder = Builder.Collings,
                ModelName = "StratoCaster",
                Type = GuitarType.Electric,
                BackWood = Wood.Alder,
                TopWood = Wood.Alder
            }));
            i.AddInstrument(new Guitar("Durian", 77.00, new GuitarSpec
            {
                Builder = Builder.Fender,
                ModelName = "stratocaster",
                Type = GuitarType.Electric,
                BackWood = Wood.Alder,
                TopWood = Wood.Alder
            }));
            i.AddInstrument(new Guitar("Eggplant", 449.95, new GuitarSpec
            {
                Builder = Builder.Fender,
                ModelName = "stratocaster",
                Type = GuitarType.Acoustic,
                BackWood = Wood.Alder,
                TopWood = Wood.Alder
            }));
            i.AddInstrument(new Mandolin("Mandolin", 44.99, new MandolinSpec {
                Builder = Builder.Ryan,
                ModelName = "mandolin aaa",
                Type = GuitarType.Acoustic,
                BackWood = Wood.Cedar,
                TopWood = Wood.Cedar,
                Style = Style.A
            }));
            i.AddInstrument(new Mandolin("Randolin", 900.00, new MandolinSpec
            {
                Builder = Builder.PRS,
                ModelName = "mandolin bbb",
                Type = GuitarType.Acoustic,
                BackWood = Wood.Cocobolo,
                TopWood = Wood.Cocobolo,
                Style = Style.A
            }));
            i.AddInstrument(new Mandolin("Zandolin", 771.50, new MandolinSpec
            {
                Builder = Builder.Ryan,
                ModelName = "mandolin ccc",
                Type = GuitarType.Acoustic,
                BackWood = Wood.Cedar,
                TopWood = Wood.Cedar,
                Style = Style.F
            }));

            return i;
        }
    }
}
