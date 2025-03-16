using JetBrains.Annotations;
using UnityEngine;

public class SaveQuitLoad : MonoBehaviour
{
    private DManager dManager;
    private MenuLoader menuLoader;
    public int SaveFile;
    private void Awake()
    {
        dManager = GetComponent<DManager>();
        menuLoader = GetComponent<MenuLoader>();
    }
    public void save()
    {
        dManager.SaveGame();
    }
    public void saveAndQuit()
    {
        SaveFile = 0;
        Debug.Log("Quit");
        Application.Quit();
    }
    public void Load()
    {
        Debug.Log("Loading... \n please wait");
    }

}
