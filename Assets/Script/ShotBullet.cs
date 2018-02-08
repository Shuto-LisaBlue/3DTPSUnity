using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShotBullet : MonoBehaviour
{

    public GameObject Bullet;
    public Transform Shooter;
    public Transform Camera;
    public float Speed = 10000.0f;
    public float Shotrate = 0.5f;
    private float LastShot = 0;
    public static float RestBullet = 30;
    public static float FullBullet = 30;
    private float ReloadTime = 1.0f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        LastShot += Time.deltaTime;
        if (RestBullet <= 0 && LastShot > ReloadTime)
        {
            RestBullet = FullBullet;
        }

        if (Input.GetMouseButton(0) && LastShot > Shotrate && RestBullet > 0)
        {
            GameObject bullets = GameObject.Instantiate(Bullet,Shooter.transform.position,Quaternion.identity) as GameObject;
            bullets.transform.position = Shooter.position;
            bullets.GetComponent<TrailRenderer>().enabled = true;
            Vector3 force;
            force = this.gameObject.transform.forward * Speed;
            bullets.GetComponent<Rigidbody>().AddForce(force, ForceMode.Impulse);
            RestBullet -= 1;
            LastShot = 0;

        }
    }
}
