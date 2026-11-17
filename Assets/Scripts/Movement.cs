using UnityEngine;

public class Movement : MonoBehaviour
{
    void Start()
    {
        
    }
     

    private float jumpPos = 0f;

    private float getSpeed()
    {
        return 150f;
    }
    private float getJumpHeight()
    {
        return 140f;
    }

    private GameObject getPlayer()
    {
        return GameObject.FindWithTag("Player");
    }
    private GameObject getGround()
    {
        return GameObject.FindWithTag("Ground");
    }

    private bool onGround()
    {
        return getPlayer().GetComponent<Collider2D>().IsTouching(getGround().GetComponent<Collider2D>());
    }

    void Update()
    {
        if (jumpPos > 0 && Mathf.Abs(getGround().transform.position.y - transform.position.y) != jumpPos)
        {
            print(Mathf.Abs(getGround().transform.position.y - transform.position.y));
            transform.position += new Vector3(0, 1, 0);
        } else
        {
            jumpPos = 0;
        }
       //     transform.position += new Vector3(0, jumpSpeed, 0);
       // jumpSpeed = Mathf.Max(0, jumpSpeed-1); 
        
        if (onGround() && (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Space)))
        {
            jumpPos = 20f;

            //transform.position = Vector3.MoveTowards(transform.position, transform.position + new Vector3(0, getJumpHeight(), 0), getSpeed() * Time.deltaTime); 
        }
    }
}

