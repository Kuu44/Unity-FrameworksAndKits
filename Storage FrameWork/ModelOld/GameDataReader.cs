using System.IO;
using System.Collections.Generic;
using UnityEngine;

public class GameDataReader
{
    public BinaryReader reader;

    public GameDataReader (BinaryReader reader)
    {
        this.reader = reader;
    }

    public float ReadFloat()
    {
        return reader.ReadSingle();
    }
    public int ReadInt()
    {
        return reader.ReadInt32();
    }
    public Quaternion ReadQuaternion()
    {
        Quaternion value;
        value.x = reader.ReadSingle();
        value.y = reader.ReadSingle();
        value.z = reader.ReadSingle();
        value.w = reader.ReadSingle();
        return value;
    }
    public Vector4 ReadVector4()
    {
        Vector4 value;
        value.x = reader.ReadSingle();
        value.y = reader.ReadSingle();
        value.z = reader.ReadSingle();
        value.w = reader.ReadSingle();
        return value;
    }
    public Vector3 ReadVector3()
    {
        Vector3 value;
        value.x = reader.ReadSingle();
        value.y = reader.ReadSingle();
        value.z = reader.ReadSingle();
        return value;
    }
    public Vector2 ReadVector2()
    {
        Vector2 value;
        value.x = reader.ReadSingle();
        value.y = reader.ReadSingle();
        return value;
    }
    }
