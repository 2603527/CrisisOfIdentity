using System;
using UnityEngine;

public class flag_logic : MonoBehaviour
{
    public GameObject[] objects;
    public GameObject player;
    Vector2 start_pos;
    public bool reset = false;
    private void Start()
    {
        start_pos = player.transform.position;
    }


    private void Update()
    {
        if (reset) { resetLevel(); };
        reset = false;
    }
    void OnTriggerEnter2D(Collider2D hit)
    {
        Debug.Log("hi");
        resetLevel();
    }

    void resetLevel()
    {
        player.transform.position = start_pos;
        reset = true;
    }
}
