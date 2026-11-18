using UnityEngine;
using UnityEngine.Events;

public class LevelManager : MonoBehaviour
{
    public int score = 0;
    GameObject temp;
    public GameObject[] scenes;
    public GameObject player;
    
    void Start()
    {
        temp = new GameObject();
        loadLevel();
    }

    public void increaseScore()
    {
        score++;
    }


    public void loadLevel()
    {
        float x_pos = 0.0f;
        Destroy(temp);

        temp = new GameObject();
        temp.transform.position = new Vector3(x_pos, transform.position.y, 0);

        Debug.Log("Making level");

        GameObject newScene = Instantiate(scenes[score % scenes.Length]);
        newScene.transform.position = new Vector3(x_pos, 0.0f, newScene.transform.position.z);
        newScene.transform.SetParent(temp.transform, false);
        x_pos += 10;

        LevelSettings settings = FindAnyObjectByType<LevelSettings>();
        player.transform.position = settings.StartPos.transform.position; 
    }
}