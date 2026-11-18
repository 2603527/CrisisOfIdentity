using UnityEngine;

public class flagLogic : MonoBehaviour
{
    private LevelManager levelManager;
    void Start()
    {
        levelManager = FindAnyObjectByType<LevelManager>();
    }
    void OnTriggerEnter2D(Collider2D hit)
    {
        levelManager.increaseScore();
        levelManager.loadLevel();
    } 
}
