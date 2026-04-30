using UnityEditor;
using UnityEngine;

public class MenuPanelController : MonoBehaviour
{
    [SerializeField] GameObject menuPanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(menuPanel.activeSelf==false && Input.GetKeyDown(KeyCode.Escape))
        {
            menuPanel.SetActive(true);
            Time.timeScale = 0;
        }
        else if(menuPanel.activeSelf==true && Input.GetKeyDown(KeyCode.Escape))
        {
            menuPanel.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
