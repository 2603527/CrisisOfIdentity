using UnityEngine;

public class Movement : MonoBehaviour
{
    void Start()
    {
        
    }

    public float speed = 5f;
     
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontal, vertical);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
