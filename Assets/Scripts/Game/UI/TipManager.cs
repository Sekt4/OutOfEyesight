using UnityEngine;
using UnityEngine.UI;
public class TipManager : MonoBehaviour
{
    [SerializeField] Text tipText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SetTip(string tip)
    {
        tipText.text = tip;
    }
}
