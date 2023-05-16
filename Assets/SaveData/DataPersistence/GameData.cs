using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public int coinAmount;

    public SerializbleDictionary<string, bool> weaponSold;
    public GameData()
    {
        this.coinAmount = 4;
        weaponSold = new SerializbleDictionary<string, bool>();
    }
}
