using UnityEngine;
using UnityEngine.Sprites;

public class LaserController : MonoBehaviour
{
    [SerializeField] Transform laser;
    [SerializeField] LayerMask layer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, - transform.right, 1000, layer);
        print(hit.collider);
        Vector2 point = hit.point;
        if(hit.collider != null)
        {
            float distance = Vector2.Distance(transform.position, point);
            Vector2 s = laser.localScale;
            s.x = distance;
            laser.localScale = s;
        }
        //Ставим точку в месте между обьектом и началом лазерного потока
        laser.position = new Vector2(
            (point.x + transform.position.x)/2, 
            (point.y + transform.position.y)/2
            );
    }
}
