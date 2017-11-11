using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logger;
using Moq;
using System.IO;
using System.Linq;

namespace LoggerUnitTests
{
    [TestClass]
    public class ConsoleOutputterTest
    {
        private ConsoleOutputter cons;
        [TestInitialize]
        public void TestInit()
        {
            cons = new ConsoleOutputter();
        }

        [TestMethod]
        public void GetInstanceTest()
        {
            Assert.IsInstanceOfType(cons, typeof(ConsoleOutputter));
        }

        [TestMethod]
        public void GetOutputTypeTest()
        {
            Assert.IsInstanceOfType(cons.GetOutputType(), typeof(OutputType));
        }

        [TestMethod]
        public void WriteLogTest()
        {

            //var writer = new Mock<IOutputWriter>();

            //var mock = new Mock<ConsoleOutputter>(writer.Object, new object[] { "question text", true });

            //mock.CallBase = true;

            //var cons = mock.Object;

            //cons.WriteLog(Level.DEBUG, "unitTest");

            //mock.Verify(m => m.WriteLog(Level.DEBUG, "unitTest"), Times.Exactly(1));
            //mock.Verify(w => w.WriteLine(It.Is<string>(s => s == "DEBUG: unitTest WHEN: " + DateTime.Now)), Times.Once);
            string expected = Level.INFO.ToString() + ": " + "unitTest" + " WHEN: " + DateTime.Now + "\r\n";
            string actual;

            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            cons.WriteLog(Level.INFO, "unitTest");

            actual = stringWriter.ToString();


            //Assert.AreEqual<string>(expected, actual);

            Assert.IsTrue(expected.SequenceEqual(actual));
        }
    }
}
