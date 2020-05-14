using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveModel
{
    public static void SaveGame(Game game)//The class inside this must be that of object to save
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/saveGame.tenOrbits";
        using (FileStream stream = new FileStream(path, FileMode.Create))
        {
            PlayerModel data = new PlayerModel(game);

            formatter.Serialize(stream, data);
            stream.Close();
        }
    }
    public static PlayerModel LoadGame()
    {
        string path = Application.persistentDataPath + "/saveGame.tenOrbits";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                PlayerModel data = formatter.Deserialize(stream) as PlayerModel;
                stream.Close();

                return data;
            }

        }
        else
        {
            Debug.Log("Save file not found in " + path);
            return null;
        }
    }
}
