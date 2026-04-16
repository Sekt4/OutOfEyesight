using UnityEditor.Analytics;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    [SerializeField] GameObject loosePanel;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Laser"))
        {
            Death();
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Death()
    {
        loosePanel.SetActive(true);
        Destroy(gameObject);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
