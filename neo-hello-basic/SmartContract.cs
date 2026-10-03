using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Attributes;
using System.ComponentModel;

namespace neo_hello_basic
{
    [DisplayName(nameof(Contract))]
    public class Contract : SmartContract
    {
        public static string Hello(string name)
        {
            return $"Hello, {name}!";
        }
    }
}