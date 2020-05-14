using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel
{
    public int integer;
    public string namee;
    public float[] vector3;
    
    public PlayerModel(Game game)//The class inside this must be that of object to save
    {
        integer = game.integer;
        namee = game.namee;

        vector3 = new float[3];
        vector3[0] = game.transform.position.x; //x comp of vector
        vector3[1] = game.transform.position.y; //y comp of vector
        vector3[2] = game.transform.position.z; //z comp of vector
    }
}
