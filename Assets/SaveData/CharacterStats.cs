using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CharacterStats 
{
    public int healthPoint;
    public string characterName;

    public CharacterStats(string characterName, int healthPoint)
    {
        this.characterName = characterName;
        this.healthPoint = healthPoint;
    }
}
