using C05b.Models;
using C05b.Enums;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace XXTests
{
    [TestClass]
    public class C05bInventoryTests
    {
        private readonly Inventory sampleInventory;

        public C05bInventoryTests()
        {
            sampleInventory = GetSampleInventory();
        }

        [TestMethod]
        public void InventoryHasNineInstruments()
        {
            Assert.AreEqual(9, sampleInventory.InventoryCount);
        }

        [TestMethod]
        public void TwoMatchesForErin()
        {
            InstrumentSpec searchSpec = new InstrumentSpec();
            searchSpec[SpecProps.Builder] = Builder.Fender;
            searchSpec[SpecProps.ModelName] = "Stratocaster";
            searchSpec[SpecProps.Type] = GuitarType.Electric;
            searchSpec[SpecProps.TopWood] = Wood.Alder;
            searchSpec[SpecProps.BackWood] = Wood.Alder;

            var matchingIntruments = sampleInventory.Search(searchSpec);

            Assert.AreEqual(2, (matchingIntruments as List<Instrument>).Count);

            foreach(Instrument match in matchingIntruments)
            {
                Assert.AreEqual(match.Spec[SpecProps.Builder], searchSpec[SpecProps.Builder]);
                Assert.IsTrue((match.Spec[SpecProps.ModelName] as String).Equals(searchSpec[SpecProps.ModelName] as String, StringComparison.OrdinalIgnoreCase));
                Assert.AreEqual(match.Spec[SpecProps.Type], searchSpec[SpecProps.Type]);
                Assert.AreEqual(match.Spec[SpecProps.TopWood], searchSpec[SpecProps.TopWood]);
                Assert.AreEqual(match.Spec[SpecProps.BackWood], searchSpec[SpecProps.BackWood]);
            }
        }
        [TestMethod]
        public void MatchResultsIncudeTwoTypesOfInstruments()
        {
            InstrumentSpec searchSpec = new InstrumentSpec();
            searchSpec[SpecProps.TopWood] = Wood.Cocobolo;
            searchSpec[SpecProps.BackWood] = Wood.Cocobolo;

            var matchingIntruments = new List<Instrument>(sampleInventory.Search(searchSpec));

            Assert.AreEqual(2, (matchingIntruments as List<Instrument>).Count);

            Assert.AreNotEqual(matchingIntruments[0].Spec[SpecProps.InstrumentType], matchingIntruments[1].Spec[SpecProps.InstrumentType]);
        }

        private Inventory GetSampleInventory()
        {
            Inventory inventory = new Inventory();
            Instrument i;

            i = new Instrument("Apple", 199.99, new InstrumentSpec());
            i.Spec[SpecProps.InstrumentType] = InstrumentType.Guitar;
            i.Spec[SpecProps.Builder] = Builder.Fender;
            i.Spec[SpecProps.ModelName] = "StratOcaster";
            i.Spec[SpecProps.Type] = GuitarType.Electric;
            i.Spec[SpecProps.BackWood] = Wood.Cedar;
            i.Spec[SpecProps.TopWood] = Wood.Cedar;
            inventory.AddInstrument(i);

            i = new Instrument("Banana", 250.55, new InstrumentSpec());
            i.Spec[SpecProps.InstrumentType] = InstrumentType.Guitar;
            i.Spec[SpecProps.Builder] = Builder.Fender;
            i.Spec[SpecProps.ModelName] = "stratocaster";
            i.Spec[SpecProps.Type] = GuitarType.Electric;
            i.Spec[SpecProps.BackWood] = Wood.Alder;
            i.Spec[SpecProps.TopWood] = Wood.Alder;
            inventory.AddInstrument(i);

            i = new Instrument("Coconut", 15.99, new InstrumentSpec());
            i.Spec[SpecProps.InstrumentType] = InstrumentType.Guitar;
            i.Spec[SpecProps.Builder] = Builder.Collings;
            i.Spec[SpecProps.ModelName] = "StratoCaster";
            i.Spec[SpecProps.Type] = GuitarType.Electric;
            i.Spec[SpecProps.BackWood] = Wood.Alder;
            i.Spec[SpecProps.TopWood] = Wood.Alder;
            inventory.AddInstrument(i);

            i = new Instrument("Durian", 77.00, new InstrumentSpec());
            i.Spec[SpecProps.InstrumentType] = InstrumentType.Guitar;
            i.Spec[SpecProps.Builder] = Builder.Fender;
            i.Spec[SpecProps.ModelName] = "stratocaster";
            i.Spec[SpecProps.Type] = GuitarType.Electric;
            i.Spec[SpecProps.BackWood] = Wood.Alder;
            i.Spec[SpecProps.TopWood] = Wood.Alder;
            inventory.AddInstrument(i);

            i = new Instrument("Eggplant", 449.95, new InstrumentSpec());
            i.Spec[SpecProps.InstrumentType] = InstrumentType.Guitar;
            i.Spec[SpecProps.Builder] = Builder.Fender;
            i.Spec[SpecProps.ModelName] = "stratocaster";
            i.Spec[SpecProps.Type] = GuitarType.Acoustic;
            i.Spec[SpecProps.BackWood] = Wood.Alder;
            i.Spec[SpecProps.TopWood] = Wood.Alder;
            inventory.AddInstrument(i);


            i = new Instrument("Mandolin", 44.99, new InstrumentSpec());
            i.Spec[SpecProps.InstrumentType] = InstrumentType.Mandolin;
            i.Spec[SpecProps.Builder] = Builder.Ryan;
            i.Spec[SpecProps.ModelName] = "mandolin aaa";
            i.Spec[SpecProps.BackWood] = Wood.Cedar;
            i.Spec[SpecProps.TopWood] = Wood.Cedar;
            i.Spec[SpecProps.Style] = Style.A;
            inventory.AddInstrument(i);

            i = new Instrument("Randolin", 900.00, new InstrumentSpec());
            i.Spec[SpecProps.InstrumentType] = InstrumentType.Mandolin;
            i.Spec[SpecProps.Builder] = Builder.PRS;
            i.Spec[SpecProps.ModelName] = "mandolin bbb";
            i.Spec[SpecProps.BackWood] = Wood.Cocobolo;
            i.Spec[SpecProps.TopWood] = Wood.Cocobolo;
            i.Spec[SpecProps.Style] = Style.A;
            inventory.AddInstrument(i);

            i = new Instrument("Zandolin", 771.50, new InstrumentSpec());
            i.Spec[SpecProps.InstrumentType] = InstrumentType.Mandolin;
            i.Spec[SpecProps.Builder] = Builder.Ryan;
            i.Spec[SpecProps.ModelName] = "mandolin ccc";
            i.Spec[SpecProps.BackWood] = Wood.Cedar;
            i.Spec[SpecProps.TopWood] = Wood.Cedar;
            i.Spec[SpecProps.Style] = Style.F;
            inventory.AddInstrument(i);

            i = new Instrument("Fig", 900.00, new InstrumentSpec());
            i.Spec[SpecProps.InstrumentType] = InstrumentType.Guitar;
            i.Spec[SpecProps.Builder] = Builder.Martin;
            i.Spec[SpecProps.ModelName] = "Figocaster";
            i.Spec[SpecProps.BackWood] = Wood.Cocobolo;
            i.Spec[SpecProps.TopWood] = Wood.Cocobolo;
            i.Spec[SpecProps.Type] = GuitarType.Electric;
            inventory.AddInstrument(i);

            return inventory;
        }
    }
}
