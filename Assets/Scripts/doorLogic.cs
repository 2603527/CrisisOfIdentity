using UnityEngine;
using System.Collections;

public class DoorLogic : MonoBehaviour
{
    private float openSpeed = 1f;
    public void openDoor()
    {
        StartCoroutine(SlideDoorOpen());
    }

    IEnumerator SlideDoorOpen()
    {
        Vector3 target = transform.position - new Vector3(0, 10, 0);

        while (Vector3.Distance(transform.position, target) > 0.01f)
        {
            transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime * openSpeed);
            yield return null;
        }
    }
}
