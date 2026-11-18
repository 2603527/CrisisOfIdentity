using System;
using UnityEngine;
using UnityEngine.Events;

public class flagLogic : MonoBehaviour
{
    public levelSpawner level;
    public UnityEvent finishLevel;

    void Start()
    {
        level = GameObject.FindAnyObjectByType<levelSpawner>();
    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        finishLevel.Invoke();
        level.resetLevel();
    }
}
