using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class OverandClick : MonoBehaviour
{
    public GameObject _Text;
    public string String1;
    public string String2;
    public string String3;
    public string String4;
    public string String5;
    public string String6;
    public int CategoryNumber;
    public bool mode2P = false;
    void Start()
    {

    }

    void Update()
    {

    }
    public void OnClick()
    {
        _Text.GetComponent<Text>().text = String1 + "\n" + String2 + "\n" + String3 + "\n" + String4 + "\n" + String5 + "\n" + String6;
        if(!mode2P)PassesScript.Category1P = CategoryNumber;
        else PassesScript.Category2P = CategoryNumber;
    }

}
