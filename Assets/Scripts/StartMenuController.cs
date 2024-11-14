using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{
    public void LoadLevel1()
    {
        SceneManager.LoadScene("13921301_Assess3");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("DesignIterationScene");
    }
    
    public void LoadMenu()
    {
        SceneManager.LoadScene("Start Scene");
    }
}

