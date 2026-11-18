using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuActions : MonoBehaviour
{
    public string scene;
    public void play()
    { 
        SceneManager.LoadScene(scene);
    }
    public void exit()
    { 
        Application.Quit();
    }
}
