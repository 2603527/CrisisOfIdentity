using UnityEngine;

public class object_logic : MonoBehaviour
{
    private levelSpawner level;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        level = GameObject.FindAnyObjectByType<levelSpawner>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            level.resetLevel();
        }
    }
}
