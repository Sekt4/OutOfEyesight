using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.InputSystem;

public class LeverController : MonoBehaviour
{
    InputAction interactAction;
    bool isTrigger = false;
    [SerializeField] Rigidbody2D boxRb;
    
    void Start()
    {
        interactAction = InputSystem.actions.FindAction("Interact");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isTrigger = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isTrigger = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(interactAction.WasPressedThisFrame() && isTrigger == true)
        {
           boxRb.gravityScale = 1;
        }
    }
}
