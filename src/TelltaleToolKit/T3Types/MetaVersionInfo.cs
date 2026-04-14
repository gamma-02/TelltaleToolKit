using System;
using System.Collections.Generic;
using System.Text;
using TelltaleToolKit.Reflection;
using TelltaleToolKit.Serialization;
using TelltaleToolKit.Serialization.Serializers;

namespace TelltaleToolKit.T3Types;

[MetaClassSerializerGlobal(typeof(DefaultClassSerializer<MetaVersionInfo>))]
public class MetaVersionInfo
{
    [MetaMember("mTypeSymbolCrc")]
    public ulong TypeSymbolCrc;

    [MetaMember("mVersionCrc")]
    public uint mVersionCrc;
}

