using System;
using UnityEngine;
using UnityEngine.Events;

public class flag_logic : MonoBehaviour
{
    public GameObject[] objects;
    public GameObject player;
    Vector2 start_pos;
    public UnityEvent resetLevelH;
    public UnityEvent finishLevelH;
    public bool finished = false;
    private void Start()
    {
        start_pos = player.transform.position;
    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        finishLevelH.Invoke();
        resetLevel();
    }

    public void resetLevel()
    {
        resetLevelH.Invoke();
        finished = false;
        player.transform.position = start_pos;
    }
}
