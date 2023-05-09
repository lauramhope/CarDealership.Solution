using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarDealership.Models;
using System;

namespace CarDealership.Tests
{
  [TestClass]
  public class CarTests
  {
    Car newCar = new Car();
    [TestMethod]
    public void CarConstructor_CreatesInstanceOfCar_Car()
    {
      Assert.AreEqual(typeof(Car), newCar.GetType());
    }
  }
}