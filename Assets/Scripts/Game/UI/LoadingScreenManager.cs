using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LoadingScreenManager : MonoBehaviour
{
    [SerializeField] Text loadingText;
    [SerializeField] Image loadingScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    IEnumerator Loading()
    {
        yield return new WaitForSeconds(7);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
