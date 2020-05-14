using UnityEngine;
using System.Collections;
using System.IO;

public class Storage : MonoBehaviour
{
    string savePath;

    private void Awake()
    {
        savePath = Path.Combine(Application.persistentDataPath, "saveFile");
    }

    public void Save(SavableObject o)
    {
        using
        (
            var writer = new BinaryWriter(File.Open(savePath, FileMode.Create))
        )
        {
            o.Save(new GameDataWriter(writer));
        }
    }
    public void Load(SavableObject o)
    {
        using
            (
            var reader = new BinaryReader(File.Open(savePath, FileMode.Open))
            )
        {
            o.Load(new GameDataReader(reader));
        }
    }
}
