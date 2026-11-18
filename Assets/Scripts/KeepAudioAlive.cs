using UnityEngine;

public class KeepAudioAlive : MonoBehaviour
{
    private void Awake()
    {
        if (FindObjectsByType<KeepAudioAlive>().Length > 1) Destroy(gameObject);
        else DontDestroyOnLoad(gameObject); 
    }
}