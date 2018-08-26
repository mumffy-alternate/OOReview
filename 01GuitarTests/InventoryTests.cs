using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _01Guitar.Models;
using _01Guitar.Enums;
using System.Collections.Generic;

namespace _01GuitarTests
{
    [TestClass]
    public class InventoryTests
    {
        private readonly Inventory sampleInventory;

        public InventoryTests()
        {
            sampleInventory = GetSampleInventory();
        }

        [TestMethod]
        public void InventoryHasFiveGuitars()
        {
            Assert.AreEqual(5, sampleInventory.GuitarCount);
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

            i.AddGuitar(new Guitar("Apple", 199.99, new GuitarSpec{
                Builder = Builder.Fender,
                ModelName = "StratOcaster",
                Type = GuitarType.Electric,
                BackWood = Wood.Cedar,
                TopWood = Wood.Cedar
            }));
            i.AddGuitar(new Guitar("Banana", 250.55, new GuitarSpec
            {
                Builder = Builder.Fender,
                ModelName = "stratocaster",
                Type = GuitarType.Electric,
                BackWood = Wood.Alder,
                TopWood = Wood.Alder
            }));
            i.AddGuitar(new Guitar("Coconut", 15.99, new GuitarSpec
            {
                Builder = Builder.Collings,
                ModelName = "StratoCaster",
                Type = GuitarType.Electric,
                BackWood = Wood.Alder,
                TopWood = Wood.Alder
            }));
            i.AddGuitar(new Guitar("Durian", 77.00, new GuitarSpec
            {
                Builder = Builder.Fender,
                ModelName = "stratocaster",
                Type = GuitarType.Electric,
                BackWood = Wood.Alder,
                TopWood = Wood.Alder
            }));
            i.AddGuitar(new Guitar("Eggplant", 449.95, new GuitarSpec
            {
                Builder = Builder.Fender,
                ModelName = "stratocaster",
                Type = GuitarType.Acoustic,
                BackWood = Wood.Alder,
                TopWood = Wood.Alder
            }));

            return i;
        }
    }
}
