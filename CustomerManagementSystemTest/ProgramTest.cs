using CustomerManagementSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerManagementSystemTest
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TestGetMessage()
        {
            string message = Program.GetMessage();
            Assert.AreEqual("Hello, from CMS!", message);
        }
    }
}
