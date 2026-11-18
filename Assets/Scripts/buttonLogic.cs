using UnityEngine;

public class ButtonLogic : MonoBehaviour
{
    public DoorLogic door;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Crate")
        {
            door.openDoor();
        };
    }
}
