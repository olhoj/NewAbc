﻿using Abc.Facade.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.Quantity
{
    [TestClass]
    public class MeasureTermViewTests: SealedClassTests<MeasureTermView, CommonTermView>
    {
        [TestMethod]
        public void MasterIdTest() => IsNullableProperty(() => obj.MasterId, x => obj.MasterId = x);
        [TestMethod]
        public void GetIdTest()
        {
            var actual = obj.GetId();
            var expected = $"{obj.MasterId}.{obj.TermId}";
            Assert.AreEqual(expected, actual);
        }
    }
}
