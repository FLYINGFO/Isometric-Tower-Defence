using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class DManager : MonoBehaviour
{
    [Header("File Config")]
    [SerializeField] private string fileName;
    private GameData gameData;
    private List<IData> dataObj;
    private FManager fManager;
    private string selectedProfileID = "test";
    public static DManager instance { get; private set; }

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Error: Duplicate detected");
        }
        instance = this;
    }
    private void Start()
    {
        this.fManager = new FManager(Application.persistentDataPath, fileName);
        this.dataObj = FindDataObj();
        LoadGame();
    }

    public void NewGame()
    {
        this.gameData = new GameData();
    }
    public void LoadGame()
    {
        if (this.gameData == null)
        {
            Debug.Log("No data found :(");
        }
        Debug.Log("Placeholder functionality, loading new game");
        NewGame();
    }
    public void SaveGame()
    {
        foreach (IData data in dataObj)
        {
            data.SaveData(ref gameData);
        }
        Debug.Log(gameData.playerPosition +"   "+ Time.time);
        fManager.Save(gameData, selectedProfileID);
    }

    private void OnApplicationQuit()
    {
        SaveGame();        
    }
    private List<IData> FindDataObj()
    {
        IEnumerable<IData> dataObj = FindObjectsByType<MonoBehaviour>(FindObjectsSortMode.None).OfType<IData>();
        return new List<IData>(dataObj);
    }
}
