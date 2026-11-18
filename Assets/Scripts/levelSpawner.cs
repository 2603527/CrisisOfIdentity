using UnityEngine;

public class levelSpawner : MonoBehaviour
{
    private float stages = 5;

    GameObject temp;
    public GameObject[] scenes;
    private flagLogic flag;
    public GameObject player;
    Vector2 start_pos;

    void Start()
    {
        flag = GameObject.FindAnyObjectByType<flagLogic>();
        start_pos = player.transform.position;
        temp = new GameObject();
        stages = flag.transform.position.x / 10;
        newLevels();
    }

    public void newLevels()
    {
        float x_pos = 0.0f;
        Destroy(temp);
        temp = new GameObject();
        temp.transform.position = new Vector3(x_pos, transform.position.y, 0);
        for (float i = 0; i < stages; i++)
        {
            Debug.Log("Making level");
            GameObject newScene = Instantiate(scenes[Random.Range(0, scenes.Length)]);
            newScene.transform.position = new Vector3(x_pos, 0.0f, newScene.transform.position.z);
            newScene.transform.SetParent(temp.transform, false);
            x_pos += 10;
        }
    }

    public void resetLevel()
    {
        newLevels();
        player.transform.position = start_pos;
    }
}