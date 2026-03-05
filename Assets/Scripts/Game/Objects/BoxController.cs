using UnityEngine;
using UnityEngine.UIElements;

public class BoxController : MonoBehaviour
{
    Rigidbody2D rb;
    private BoxCollider2D boxCollider;
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Floor"))
        {
            boxCollider.isTrigger = false; 
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
