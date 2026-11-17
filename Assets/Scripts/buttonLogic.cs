using UnityEngine;

public class buttonLogic : MonoBehaviour
{
    public doorLogic door;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Crate")
        {
            door.openDoor();
        };
    }
}
