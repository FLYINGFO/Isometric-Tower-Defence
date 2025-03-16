using UnityEngine;

public class MenuLoader : MonoBehaviour
{
    [SerializeField] GameObject menuL;
    [SerializeField] GameObject menuS;
    public bool menuLoadedL;
    public bool menuLoadedS;
    public void loadMenuL()
    {
        if (menuLoadedL)
        {
            menuL.SetActive(false);
            menuLoadedL = false;
        }
        else
        {
            if (menuLoadedS)
            {
                menuS.SetActive(false);
                menuLoadedS = false;
            }
            menuL.SetActive(true);
            Time.timeScale = 0;
            menuLoadedL = true;
        }
    }
    public void loadMenuS()
    {
        if (menuLoadedS)
        {
            menuS.SetActive(false);
            menuLoadedS = false;
        }
        else
        {
            if (menuLoadedL)
            {
                menuL.SetActive(false);
                menuLoadedL = false;
            }
            menuS.SetActive(true);
            Time.timeScale = 0;
            menuLoadedS = true;
        }
    }
}

