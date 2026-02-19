using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    InputAction moveAction;
    InputAction sprintAction;
    Rigidbody2D rb;
    [SerializeField] float moveSpeed = 5;
    [SerializeField] float walkSpeed = 5;
    [SerializeField] float sprintSpeed = 8;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveAction = InputSystem.actions.FindAction("Move");
        sprintAction = InputSystem.actions.FindAction("Sprint");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveVector = moveAction.ReadValue<Vector2>();
        rb.linearVelocity = moveVector * moveSpeed;

        if(sprintAction.IsPressed() && moveSpeed != sprintSpeed)
        {
            moveSpeed = sprintSpeed;
        }
        else if(!sprintAction.IsPressed() && moveSpeed == sprintSpeed)
        {
            moveSpeed = walkSpeed;
        }
        if(moveVector.x > 0)
        {
            Vector3 s = transform.localScale;
            s.x = -Mathf.Abs(s.x);
            transform.localScale = s;
        }
        if(moveVector.x < 0)
        {
            Vector3 s = transform.localScale;
            s.x = Mathf.Abs(s.x);
            transform.localScale = s;
        }
    }
}
