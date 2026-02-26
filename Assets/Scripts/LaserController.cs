using UnityEngine;
using UnityEngine.Sprites;

public class LaserController : MonoBehaviour
{
    [SerializeField] Transform laser;
    [SerializeField] LayerMask layer;
    SpriteRenderer sr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = laser.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, - transform.right, 1000, layer);
        print(hit.collider);
        Vector2 point = hit.point;
        print(point);
        if(hit.collider != null)
        {
            float distance = Vector2.Distance(transform.position, point);
            sr.size = new Vector2(distance/2, sr.size.y);
            //sr.size = Vector2.zero;
            //print(sr.size);
            // Vector2 s = laser.localScale;
            // s.x = distance;
            // laser.localScale = s;
        }
        //Ставим точку в месте между обьектом и началом лазерного потока
        laser.position = new Vector2(
            (point.x + transform.position.x)/2, 
            (point.y + transform.position.y)/2
            );
            print(laser.position);
    }
}
