using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestSimpleProject
{
    [TestClass]
    public class Unittestpromt
    {

        [TestMethod]
        public void Testpromt() {

            MyClass TestClass= new MyClass();

               //arrange
               // public string prompt(string name)

            string Teststring = "Mike";

            string ExpectedTeststring = "Hello, Mike";

            //act

            MyClass testclass = new MyClass();

            string realresult = TestClass.prompt(Teststring);


            StringAssert.Equals(ExpectedTeststring, realresult);





        }



        [TestMethod]
        public void TestHello()
        {

            MyClass TestClass = new MyClass();

               //arrange
               // public string prompt(string name)

            string Teststring = "Mike";

            string ExpectedTeststring = "Hello, Mike";

            //act

            MyClass testclass = new MyClass();

            string Realresult = TestClass.prompt(Teststring);


            StringAssert.StartsWith(Realresult, "Hello");


           

        }
    }
}
