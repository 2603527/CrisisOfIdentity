using UnityEngine;

public class levelSpawner : MonoBehaviour
{
    public float stages = 5;


    public GameObject[] scenes;
    public flag_logic flag;
    
    void Start()
    {
        stages = flag.transform.position.x / 10;
        newLevels();
    }

    void newLevels()
    {
        float x_pos = 0.0f;
        for(float i = 0; i < stages; i++)
        {
            Debug.Log("Making level");
            GameObject newScene = Instantiate(scenes[Random.Range(0, scenes.Length)]);
            newScene.transform.position = new Vector3(x_pos, transform.position.y, newScene.transform.position.z);
            x_pos += 10;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (flag.reset == true)
        {
            newLevels();
        }
    }
}