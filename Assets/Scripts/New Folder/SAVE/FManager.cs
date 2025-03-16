using UnityEngine;
using System;
using System.IO;

public class FManager
{
    private string dataDirPath = "";
    private string dataFileName = "";

    public FManager(string dataDirPath, string dataFileName)
    {
        this.dataDirPath = dataDirPath;
        this.dataFileName = dataFileName;
    }

    public void Save(GameData data, string profileID)
    {
        string fullPath = Path.Combine(dataDirPath, profileID, dataFileName);
        try
        {
            Directory.CreateDirectory(Path.GetDirectoryName(fullPath));
            string dataStore = JsonUtility.ToJson(data, true);
            using (FileStream stream = new FileStream(fullPath, FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(dataStore);
                }
            }
        }
        catch (Exception e )
        {
            Debug.LogError("Error occured while saving data to file: " + fullPath + "\n" + e);
        }
    }
}
