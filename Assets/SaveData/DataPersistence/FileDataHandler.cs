using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
public class FileDataHandler
{
    private string dataDirPath = "";
    private string dataFileName = "";

    public FileDataHandler(string dataDirPath, string dataFileName)
    {
        this.dataDirPath = dataDirPath;
        this.dataFileName = dataFileName;
    }
    public GameData Load()
    {
        string fullPath = Path.Combine(dataDirPath, dataFileName);
        GameData loadedData = null;
        if (File.Exists(fullPath))
        {
            try
            {
                string datatoLoad = "";
                using (FileStream stream = new FileStream(fullPath, FileMode.Open))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        datatoLoad = reader.ReadToEnd();
                    }
                }
                loadedData = JsonUtility.FromJson<GameData>(datatoLoad);
            }
            catch (Exception e)
            {
                Debug.LogError("Error occur when trying to load data to file: " + fullPath + "\n" + e);

            }
        }
        return loadedData;
    }
    public void Save(GameData data)
    {
        string fullPath = Path.Combine(dataDirPath, dataFileName);
        try
        {
            //dosya konumu yoksa oluþtur
            Directory.CreateDirectory(Path.GetDirectoryName(fullPath));
            //C# dosyasýný json a kaydet
            string dataToStore = JsonUtility.ToJson(data, true);
            //Dosyaya oluþturulan veriyi yazdýr
            using (FileStream stream = new FileStream(fullPath, FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(dataToStore);
                }
            }

        }
        catch (Exception e)
        {

            Debug.LogError("Error occur when trying to save data to file: " + fullPath + "\n" + e);
        }
    }

}
