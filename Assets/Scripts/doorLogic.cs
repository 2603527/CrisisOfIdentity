using UnityEngine;

public class doorLogic : MonoBehaviour
{

    public void openDoor()
    {
        Debug.Log("hi");
        Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
