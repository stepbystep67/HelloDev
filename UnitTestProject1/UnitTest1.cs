using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloDev.Models;


namespace UnitTestProject1
{


    [TestClass]
    public class UnitTest1
    {


        Dal_restaurant dal_resto = new Dal_restaurant();


        [TestMethod]
        public void TestMethodAdd()
        {


            Restaurant resto1 = new Restaurant();


            resto1.Nom = "restau tapas";
            resto1.Telephone = "33333333";
            resto1.Specialite = "latine";

            int nbResto = dal_resto.GetRestaurants().Count;

            dal_resto.AddRestaurant(resto1);

            Assert.AreEqual((nbResto + 1), dal_resto.GetRestaurants().Count);


        }


    }

}

