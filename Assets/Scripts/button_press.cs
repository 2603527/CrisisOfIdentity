using UnityEngine;
using UnityEngine.SceneManagement;

public class button_press : MonoBehaviour
{
    public string scene;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void play_pressed()
    {
        Debug.Log("pressed");
        SceneManager.LoadScene(scene);
    }
    public void exit_pressed()
    {
        Debug.Log("pressed");
        Application.Quit();
    }
}
