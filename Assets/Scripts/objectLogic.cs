using UnityEngine;

public class object_logic : MonoBehaviour
{
    private flag_logic flag;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        flag = GameObject.FindAnyObjectByType<flag_logic>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        flag.resetLevel();
    }
}
