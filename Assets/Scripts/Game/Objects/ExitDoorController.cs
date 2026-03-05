using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ExitDoorController : MonoBehaviour
{
    private KeyController keyController;
    InputAction interactAction;
    [SerializeField] bool canExit = false;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            canExit = true;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        interactAction = InputSystem.actions.FindAction("Interact");
    }

    void Update()
    {
        if(canExit == true && interactAction.WasPressedThisFrame())
        {
            SceneManager.LoadScene("Level2");
        }
    }
}
