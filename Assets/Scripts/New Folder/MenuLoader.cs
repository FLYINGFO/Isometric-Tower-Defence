using UnityEngine;

public class MenuLoader : MonoBehaviour
{
    [SerializeField] GameObject menu;
    public bool menuLoaded;
    public void loadMenu()
    {
        if (menuLoaded)
        {
            menu.SetActive(false);
            menuLoaded = false;
        }
        else
        {
            menu.SetActive(true);
            Time.timeScale = 0;
            menuLoaded = true;
        }
    }
}

