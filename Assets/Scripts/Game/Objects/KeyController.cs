using Unity.VisualScripting;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    [SerializeField] ExitDoorController exitDoorController;
    void Start()
    {
        exitDoorController.enabled = false;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Key"))
        {
            DoorUnlock();
            Destroy(collision.gameObject);
        }
    }

    void DoorUnlock()
    {
        exitDoorController.enabled = true;
    }

    
}
