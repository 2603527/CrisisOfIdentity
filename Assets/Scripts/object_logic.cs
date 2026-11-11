using UnityEngine;

public class object_logic : MonoBehaviour
{
    public flag_logic flag;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        flag.reset = true;
    }
    // Update is called once per frame
    void Update()
    {
        if(flag.reset == true)
        {
            transform.position += Vector3.up;
        }
    }
}
