using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Packer.Models;
using System;

namespace Packer.Tests
{
    [TestClass]
    public class ItemTEsts : IDisposable
    {
        public void Dispose()
        {
            Tracker.ClearAll();
        }
        [TestMethod]
        public void TrackerConstructor_CreatInstancesOfTracker_Tracker()
        {
            Tracker newTracker = new Tracker("test","test","test","test");
            Assert.AreEqual(typeof(Tracker), newTracker.GetType());
        }
    }
}