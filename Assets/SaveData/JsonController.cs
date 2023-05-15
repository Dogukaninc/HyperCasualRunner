using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class JsonController : MonoBehaviour
{
    //public CharacterStats player = new CharacterStats("Dogukan", 45);
    public GameManager gameManager;
    //public GameManager gameManager = new GameManager();
    private void Start()
    {
        SaveData();
    }
    public void SaveData()
    {
        string jsonString = JsonUtility.ToJson(gameManager);
        File.WriteAllText(Application.dataPath + "/Saves/playerJson.json", jsonString);
    }
    public void LoadData()
    {
        string path = Application.dataPath + "/Saves/playerJson.json";
        if (File.Exists(path))
        {
            string reader = File.ReadAllText(path);
            gameManager = JsonUtility.FromJson<GameManager>(reader);
        }
        else
        {
            Debug.LogError("No Saved Data!!!");
        }
    }
}
