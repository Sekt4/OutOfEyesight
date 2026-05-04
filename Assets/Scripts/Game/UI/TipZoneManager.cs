using UnityEngine;
using UnityEngine.UI;
public class TipZoneManager : MonoBehaviour
{
    [SerializeField] Text tipText;
    [SerializeField] string tip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            tipText.text = tip;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
       if (collision.CompareTag("Player"))
        {
            tipText.text = "";
        } 
    }
}
