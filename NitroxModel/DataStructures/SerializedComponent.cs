using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NitroxModel.DataStructures;

/// <summary>
/// Holds an Unity component's data to be restored on clients.
/// </summary>
[Serializable, DataContract]
public class SerializedComponent
{
    [DataMember(Order = 1)]
    public string TypeName { get; set; }

    [DataMember(Order = 2)]
    public bool IsEnabled { get; set; }

    [DataMember(Order = 3)]
    public byte[] Data { get; set; }

    protected SerializedComponent()
    {
        //Constructor for serialization. Has to be "protected" for json serialization.
    }

    public SerializedComponent(string typeName, bool isEnabled, byte[] data)
    {
        TypeName = typeName;
        IsEnabled = isEnabled;
        Data = data;
    }

    // Generated by Visual Studio
    public override bool Equals(object obj)
    {
        return obj is SerializedComponent component &&
               TypeName == component.TypeName &&
               IsEnabled == component.IsEnabled &&
               EqualityComparer<byte[]>.Default.Equals(Data, component.Data);
    }

    public override int GetHashCode()
    {
        int hashCode = -1120560399;
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TypeName);
        hashCode = hashCode * -1521134295 + IsEnabled.GetHashCode();
        hashCode = hashCode * -1521134295 + EqualityComparer<byte[]>.Default.GetHashCode(Data);
        return hashCode;
    }
}