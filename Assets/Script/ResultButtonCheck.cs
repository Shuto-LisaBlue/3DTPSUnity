using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultButtonCheck : MonoBehaviour {

    public bool GotoBattle;
    public GameObject _gameObject;
    ResultSlideIn resultSlide;


	// Use this for initialization
	void Start () {
        resultSlide = _gameObject.GetComponent<ResultSlideIn>();
	}

    public void OnClick()
    {
        if(!GotoBattle)
        {
            resultSlide.GotoTitle = true;
        }
        else
        {
            resultSlide.GotoBattle = true;
        }
            
    }
}
