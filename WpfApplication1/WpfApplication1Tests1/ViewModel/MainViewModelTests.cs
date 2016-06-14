using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApplication1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace WpfApplication1.ViewModel.Tests
{
    [TestClass()]
    public class MainViewModelTests
    {
        [TestMethod()]
        public void CreateTest()
        {
            
        }

        [TestMethod()]
        [TestCase(0, 1)]
        [TestCase(2, 3)]
        [TestCase(7, 8)]
        [TestCase(39, 40)]
        [TestCase(-4, -3)]
        public void IncrementTest(int initValue, int expectedValue)
        {
            MainViewModel vm = new MainViewModel();
            vm.Value = initValue;
            vm.Increment();
            Assert.AreEqual(expectedValue, vm.Value);
        }

        [TestMethod()]
        public void CanIncrementTest()
        {
            MainViewModel vm = new MainViewModel();
            Assert.IsTrue(vm.CanIncrement());
        }

        [TestMethod()]
        [TestCase(0,-1)]
        [TestCase(-6, -7)]
        [TestCase(9, 8)]
        [TestCase(48, 47)]
        [TestCase(-289, -290)]
        public void DecrementTest(int initValue, int expectedValue)
        {
            MainViewModel vm = new MainViewModel();
            vm.Value = initValue;
            vm.Decrement();
            Assert.AreEqual(expectedValue, vm.Value);
        }

        [TestMethod()]
        public void CanDecrementTest()
        {
            MainViewModel vm = new MainViewModel();
            Assert.IsTrue(vm.CanDecrement());
        }
    }
}