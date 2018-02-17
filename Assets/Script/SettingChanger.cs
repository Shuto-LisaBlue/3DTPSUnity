using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingChanger : MonoBehaviour
{
    public bool mode2P;
    public bool NowSelectMaker;
    public GameObject Category;
    public GameObject Maker;
    public bool  NextScene = false;

    void Start()
    {
        //      Category = GameObject.Find("CanvasCategory");
        //       Maker = GameObject.Find("Canvasmaker");
        Maker.SetActive(false);
        GetComponent<Button>().interactable = false;
    }

    void Update()
    {
        if (!mode2P && !NowSelectMaker && PassesScript.Category1P != 0) GetComponent<Button>().interactable = true;
        else if (!mode2P && NowSelectMaker && PassesScript.GunLevel1P != 0) GetComponent<Button>().interactable = true;

        if (mode2P && !NowSelectMaker && PassesScript.Category2P != 0) GetComponent<Button>().interactable = true;
        else if (mode2P && NowSelectMaker && PassesScript.GunLevel2P != 0) GetComponent<Button>().interactable = true;
    }

    public void OnClick()
    {
        if (!mode2P)
        {
            if (!NowSelectMaker && PassesScript.Category1P != 0)
            {
                Category.SetActive(false);
                Maker.SetActive(true);
            }
            else if (NowSelectMaker && PassesScript.GunLevel1P != 0)
            {
                NextScene = true;
            }

        }
        else
        {
            if (!NowSelectMaker && PassesScript.Category2P != 0)
            {
                Category.SetActive(false);
                Maker.SetActive(true);
            }
            else if (NowSelectMaker && PassesScript.GunLevel2P != 0)
            {
                NextScene = true;
            }

        }
    }
}
