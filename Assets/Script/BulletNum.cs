using UnityEngine;
using UnityEngine.UI;
using System;

public class BulletNum : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    { 
           GetComponent<Text>().text = (ShotBullet.RestBullet).ToString();  
    }
}
