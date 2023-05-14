using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class JsonController : MonoBehaviour
{
    public CharacterStats player = new CharacterStats("Dogukan", 45);
    private void Start()
    {
        SaveData();
    }
    public void SaveData()
    {
        string jsonString = JsonUtility.ToJson(player);
        File.WriteAllText(Application.dataPath + "/Saves/playerJson.json", jsonString);
    }
    public void LoadData()
    {
        string path = Application.dataPath + "/Saves/playerJson.json";
        if (File.Exists(path))
        {
            string reader = File.ReadAllText(path);
            player = JsonUtility.FromJson<CharacterStats>(reader);
        }
        else
        {
            Debug.LogError("No Saved Data!!!");
        }
    }
}
