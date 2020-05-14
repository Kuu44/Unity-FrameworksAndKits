using UnityEngine;
using System.Collections.Generic;
using System.IO;

public class Game : MonoBehaviour
{ 
    public int integer;
    public string namee;

    public void SaveGameObject()
    {
        SaveModel.SaveGame(this);
    }
    public void LoadGameObject()
    {
        PlayerModel data = SaveModel.LoadGame();

        #region Value assignment

        integer = data.integer;
        namee = data.namee;

        Vector3 vector3;
        vector3.x = data.vector3[0];
        vector3.y = data.vector3[1];
        vector3.z = data.vector3[2];
        #endregion
    }   
    
}
