using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShotBullet2P : MonoBehaviour
{
    private GameObject Bullet;
    public Transform Shooter;
    public Transform Camera;
    public float Speed = 100.0f;
    public float Shotrate = 0.5f;
    public float LastShot = 0;
    private bool ShotCheck = false;
    public float RestBullet = 30;
    public float FullBullet = 30;
    public int Pellet = 1;
    public bool AutoShot = true;
    public float ReloadTime = 1.0f;
    public float ReticleNoise = 0;//レティクルの暴れっぷり
    public float ReticleNMin = 0.03f;//いわゆる初弾精度
    public float ReticleNMax = 1f;//いわゆる初弾精度
    public float ReticletoUp = 0.5f;//レティクルの暴れる速度
    public float ReticletoZero = 0.003f;//レティクルが元に戻る速度
    public int GunLevel = 1;//1-4;
    public GameObject BulletLv1;
    public GameObject BulletLv2;
    public GameObject BulletLv3;
    public GameObject BulletLv4;
    public AudioClip audioClip;
    public AudioClip audioClip2;
    private AudioSource audioSource;
    private bool ReloadSE = false;

    // Use this for initialization
    void Start()
    {
        ReticleNoise = ReticleNMin;
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip;

        Speed = PassesScript.Speed2P;
        Shotrate = PassesScript.Shotrate2P;
        RestBullet = PassesScript.RestBullet2P;
        FullBullet = PassesScript.FullBullet2P;
        Pellet = PassesScript.Pellet2P;
        AutoShot = PassesScript.AutoShot2P;
        ReloadTime = PassesScript.ReloadTime2P;
        ReticleNoise = PassesScript.ReticleNoise2P;
        ReticleNMin = PassesScript.ReticleNMin2P;
        ReticleNMax = PassesScript.ReticleNMax2P;
        ReticletoUp = PassesScript.ReticletoUp2P;
        ReticletoZero = PassesScript.ReticletoZero2P;
        GunLevel = PassesScript.GunLevel2P;

    }

    // Update is called once per frame
    void Update()
    {
        switch (GunLevel)
        {
            case 1:
                Bullet = BulletLv1;
                break;
            case 2:
                Bullet = BulletLv2;
                break;
            case 3:
                Bullet = BulletLv3;
                break;
            case 4:
                Bullet = BulletLv4;
                break;
            default:
                Bullet = BulletLv1;
                break;
        }
        LastShot += Time.deltaTime;
        ReticleNoise -= ReticletoZero;
        if (ReticleNoise < ReticleNMin) ReticleNoise = ReticleNMin;

        if (RestBullet <= 0 && LastShot > ReloadTime)
        {
            RestBullet = FullBullet;
            ReticleNoise = 0;
            audioSource.clip = audioClip;
        }
        if (Input.GetAxis("Reload2P") != 0 && RestBullet != FullBullet)
        {
            ReloadSE = true;
            RestBullet = 0;
            LastShot = 0;
        }
        if (ReloadSE == true)
        {
            audioSource.clip = audioClip2;
            audioSource.Play();
            ReloadSE = false;
        }

        if (AutoShot == true)
        {
            if (Input.GetAxis("Fire12P") != 0 && LastShot > Shotrate && RestBullet > 0)
            {
                for (int i = 0; i < Pellet; i++)
                {
                    audioSource.Play();
                    GameObject bullets = GameObject.Instantiate(Bullet, Shooter.transform.position, Quaternion.identity) as GameObject;
                    bullets.transform.position = Shooter.position;
                    bullets.GetComponent<TrailRenderer>().enabled = true;
                    Vector3 force;
                    float NoiseX = Random.Range(ReticleNoise * -1, ReticleNoise);
                    float NoiseY = Random.Range(ReticleNoise * -1, ReticleNoise);
                    float NoiseZ = Random.Range(ReticleNoise * -1, ReticleNoise);
                    force = (this.gameObject.transform.forward + new Vector3(NoiseX, NoiseY, NoiseZ)) * Speed;

                    bullets.GetComponent<Rigidbody>().AddForce(force, ForceMode.Impulse);
                    ReticleNoise += ReticletoUp;
                    if (ReticleNoise > ReticleNMax) ReticleNoise = ReticleNMax;

                }
                RestBullet -= 1;
                LastShot = 0;
                if (RestBullet <= 0) ReloadSE = true;
            }
        }
        else
        {
            if (Input.GetAxis("Fire12P") != 0 && ShotCheck == false && LastShot > Shotrate && RestBullet > 0)
            {
                for (int i = 0; i < Pellet; i++)
                {
                    audioSource.Play();
                    GameObject bullets = GameObject.Instantiate(Bullet, Shooter.transform.position, Quaternion.identity) as GameObject;
                    bullets.tag = "Bullet2P";
                    bullets.transform.position = Shooter.position;
                    bullets.GetComponent<TrailRenderer>().enabled = true;
                    Vector3 force;
                    float NoiseX = Random.Range(ReticleNoise * -1, ReticleNoise);
                    float NoiseY = Random.Range(ReticleNoise * -1, ReticleNoise);
                    float NoiseZ = Random.Range(ReticleNoise * -1, ReticleNoise);
                    force = (this.gameObject.transform.forward + new Vector3(NoiseX, NoiseY, NoiseZ)) * Speed;

                    bullets.GetComponent<Rigidbody>().AddForce(force, ForceMode.Impulse);
                    ReticleNoise += ReticletoUp;
                    if (ReticleNoise > ReticleNMax) ReticleNoise = ReticleNMax;
                }
                RestBullet -= 1;
                LastShot = 0;
                ShotCheck = true;
                if (RestBullet <= 0) ReloadSE = true;
            }
            else if (Input.GetAxis("Fire12P") == 0) ShotCheck = false;

        }

    }
}
