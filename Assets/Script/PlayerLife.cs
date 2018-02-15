using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour {

    [Range(0, 100)] public float Life = 100;
    private float Anti = 0;
    public GameObject DamageEffect;
    public bool Mode2P = false;
    public bool KnockOut = false;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        DamageEffect.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Anti / 255.0f);
        Anti -= 10f;
        if(Life < 0)
        {
            Life = 0;
            KnockOut = true;
        }
	}
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == 8)
        {
            if (Mode2P == false && other.gameObject.tag == "Bullet2P")
            {
                Life -= other.gameObject.GetComponent<Rigidbody>().velocity.magnitude / 10f;
                Anti = 255.0f;
            }
            else if (Mode2P == true && other.gameObject.tag == "Bullet1P")
            {
                Life -= other.gameObject.GetComponent<Rigidbody>().velocity.magnitude / 10f;
                Anti = 255.0f;

            }
            else
            {
                Life -= other.gameObject.GetComponent<Rigidbody>().velocity.magnitude / 5f;
                Anti = 50f;
            }
        }
    }
}
