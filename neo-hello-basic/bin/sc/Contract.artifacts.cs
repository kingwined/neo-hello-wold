using Neo.Cryptography.ECC;
using Neo.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;

#pragma warning disable CS0067

namespace Neo.SmartContract.Testing;

public abstract class Contract(Neo.SmartContract.Testing.SmartContractInitialize initialize) : Neo.SmartContract.Testing.SmartContract(initialize), IContractInfo
{
    #region Compiled data

    public static Neo.SmartContract.Manifest.ContractManifest Manifest => Neo.SmartContract.Manifest.ContractManifest.Parse(@"{""name"":""Contract"",""groups"":[],""features"":{},""supportedstandards"":[],""abi"":{""methods"":[{""name"":""hello"",""parameters"":[{""name"":""name"",""type"":""String""}],""returntype"":""String"",""offset"":0,""safe"":false}],""events"":[]},""permissions"":[],""trusts"":[],""extra"":{""nef"":{""optimization"":""Basic""}}}");

    /// <summary>
    /// Optimization: "Basic"
    /// </summary>
    public static Neo.SmartContract.NefFile Nef => Convert.FromBase64String(@"TkVGM05lby5Db21waWxlci5DU2hhcnAgMy4xMC4wKzViMGI2Mzg4MGI2MjAxYWUzZjk3NGNjODQ1ZTkzYTkwNDYuLi4AAAAAABdXAAEMB0hlbGxvLCB4iwwBIYvbKCICQKk2Wu4=").AsSerializable<Neo.SmartContract.NefFile>();

    #endregion

    #region Unsafe methods

    /// <summary>
    /// Unsafe method
    /// </summary>
    /// <remarks>
    /// Script: VwABDAdIZWxsbywgeIsMASGL2ygiAkA=
    /// INITSLOT 0001 [64 datoshi]
    /// PUSHDATA1 48656C6C6F2C20 [8 datoshi]
    /// LDARG0 [2 datoshi]
    /// CAT [2048 datoshi]
    /// PUSHDATA1 21 '!' [8 datoshi]
    /// CAT [2048 datoshi]
    /// CONVERT 28 'ByteString' [8192 datoshi]
    /// JMP 02 [2 datoshi]
    /// RET [0 datoshi]
    /// </remarks>
    [DisplayName("hello")]
    public abstract string? Hello(string? name);

    #endregion
}
