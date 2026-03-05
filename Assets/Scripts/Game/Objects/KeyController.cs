using Unity.VisualScripting;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    [SerializeField] bool gotKey = false;
    private ExitDoorController exitDoorController;
    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Key"))
        {
            gotKey = true;
            Destroy(collision.gameObject);
        }
    }

    void DoorUnlock()
    {
        if(gotKey == true && exitDoorController == false)
        {
            exitDoorController.enabled = true;
        }
    }

    
}
