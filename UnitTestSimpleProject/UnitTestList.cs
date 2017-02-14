using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleProject;
using System.Collections.Generic;

namespace UnitTestSimpleProject
{
    [TestClass]
    public class UnitTestList
    {

        private MyClass TestClass;

        [TestInitialize]
        public void TestInit()
        {
            TestClass = new MyClass();


        }

        [TestMethod]
        public void TestNotContainNull()
        {
            //arrange
            List<double> vector = new List<double>();

            vector.Add(1);
            vector.Add(2);
            vector.Add(3);

            //act
            List<double> expectedResult = new List<double>();

            expectedResult.Add(2);
            expectedResult.Add(3);
            expectedResult.Add(4);


            List<double> realResult = TestClass.increment_vector(vector);

            CollectionAssert.AllItemsAreNotNull(realResult);



        }

        [TestMethod]
        public void TestCorrectResult()
        {
            //arrange
            List<double> vector = new List<double>();

            vector.Add(1);
            vector.Add(2);
            vector.Add(3);

            //act
            List<double> expectedResult = new List<double>();

            expectedResult.Add(2);
            expectedResult.Add(3);
            expectedResult.Add(4);


            List<double> realResult = TestClass.increment_vector(vector);

            CollectionAssert.AreEqual(expectedResult, realResult);





        }



        [TestMethod]
        public void TestTestTypeDouble()
        {
            //arrange
            List<double> vector = new List<double>();

            vector.Add(1);
            vector.Add(2);
            vector.Add(3);

            //act
            List<double> expectedResult = new List<double>();

            expectedResult.Add(2);
            expectedResult.Add(3);
            expectedResult.Add(4);


            List<double> realResult = TestClass.increment_vector(vector);
            double x=0;

            CollectionAssert.AllItemsAreInstancesOfType(realResult, x.GetType());




        }
    }
}
