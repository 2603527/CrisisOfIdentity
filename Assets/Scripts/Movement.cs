using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float jumpHeight = 9f;
    private float moveSpeed = 5f;

    public Sprite idleSprite;
    public Sprite runSprite;
    public Sprite jumpSprite;
    private SpriteRenderer sprite;
    private Rigidbody2D rb;
    private Collider2D playerCollider;

    void Start()
    {
        // Declare player component vars
        rb = GetComponent<Rigidbody2D>();
        playerCollider = GetComponent<Collider2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private Rigidbody2D[] surfaces()
    {
        return FindObjectsByType<Rigidbody2D>();
    }

    // Check if the player is standing on a surface
    private bool grounded()
    {
        foreach (Rigidbody2D floor in surfaces())
        {
            Collider2D floorCollider = floor.GetComponent<Collider2D>();

            if (floorCollider != null &&
                playerCollider.IsTouching(floorCollider))
            {
                return true;
            }
        }

        return false;
    }

    void Update()
    {
        float moveDirection = 0f;
        // Check where player is moving
        bool movingLeft = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);
        bool movingRight = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);
        bool movingUp = (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space));

        // Update sprite based on movement
        if (!grounded() && jumpSprite) sprite.sprite = jumpSprite;
        else if ((movingLeft || movingRight) && runSprite) sprite.sprite = runSprite;
        else if (idleSprite) sprite.sprite = idleSprite;

        if (movingLeft) moveDirection = -1f;
        if (movingRight) moveDirection = 1f;

        // Set linear velocity of rigidbody using move speed
        rb.linearVelocity = new Vector2(
            moveDirection * moveSpeed,
            rb.linearVelocity.y
        );

        // Move player up if jumping & grounded
        if (movingUp && grounded())
        {
            rb.linearVelocity = new Vector2(
                rb.linearVelocity.x,
                jumpHeight
            );
        }

    }
}