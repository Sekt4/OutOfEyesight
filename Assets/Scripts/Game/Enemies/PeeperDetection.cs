using UnityEngine;
using UnityEngine.Rendering;
using System.Collections;
using System;
public class CameraDetection : MonoBehaviour
{
    [SerializeField] Color32 warningColor;
    [SerializeField] Color32 dangerColor;
    [SerializeField] PlayerInteractions playerInteractions;
    SpriteRenderer sr;
    String state = "Green";

    Color32 greenColor;
    IEnumerator SetDanger()
    {
        yield return new WaitForSeconds(2);
        sr.color = dangerColor;
        state = "Danger";
        StartCoroutine("DeathTimer");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if(state == "Green")
            {
                sr.color = warningColor;
                StartCoroutine("SetDanger");
                state = "Warning";
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if(state == "Warning")
            {
                sr.color = greenColor;
                StopCoroutine("SetDanger");
                state = "Green";
            }
        }
    }
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        greenColor = sr.color;
    }
    IEnumerator DeathTimer()
    {
        yield return new WaitForSeconds(2);
        playerInteractions.Death();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
