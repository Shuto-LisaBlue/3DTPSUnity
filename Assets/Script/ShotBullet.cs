using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotBullet : MonoBehaviour {

    public GameObject Bullet;
    public Transform Shooter;
    public float Speed = 10000.0f;
    public float Shotrate = 0.5f;
    private float LastShot = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        LastShot += Time.deltaTime;
		if(Input.GetMouseButton(0) && LastShot > Shotrate)
        {
            GameObject bullets = GameObject.Instantiate(Bullet) as GameObject;
            Vector3 force;
            force = this.gameObject.transform.forward * Speed;
            bullets.GetComponent<Rigidbody>().AddForce(force,ForceMode.Impulse);
            bullets.transform.position = Shooter.position;

            LastShot = 0;
        }
	}
}
