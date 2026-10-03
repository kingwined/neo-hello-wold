using Microsoft.VisualStudio.TestTools.UnitTesting;
using Neo.SmartContract.Testing;
using ContractArtifact = Neo.SmartContract.Testing.Contract;

namespace neo_hello_basic.UnitTests
{
    [TestClass]
    public class SmartContractTests
    {
        private readonly ContractArtifact contractUnderTest;

        public SmartContractTests()
        {
            var engine = new TestEngine(true);
            contractUnderTest = engine.Deploy<ContractArtifact>(ContractArtifact.Nef, ContractArtifact.Manifest);
        }

        [TestMethod]
        public void Hello_ReturnsGreetingWithName()
        {
            Assert.AreEqual("Hello, Neo!", contractUnderTest.Hello("Neo"));
        }
    }
}