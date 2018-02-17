using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class JoyPadCheck : MonoBehaviour {

    public bool mode2P;
    public static bool PadCheckMode = false;
    public static bool PadCheckPlayer1 = false;
    public static bool PadCheckPlayer2 = false;

    void Start () {
        PadCheckPlayer1 = false;
        PadCheckPlayer2 = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(PadCheckMode)
        {
            if(!mode2P)
            {
                if(Input.GetAxis("Reload1P") != 0)
                {
                    GetComponent<Image>().color = new Color(1f, 1f, 1f);
                    PadCheckPlayer1 = true;
                }
                       
            }
            else
            {
                if (Input.GetAxis("Reload2P") != 0)
                {
                    GetComponent<Image>().color = new Color(1f, 1f, 1f);
                    PadCheckPlayer2 = true;
                }
            }
        }
	}
}
