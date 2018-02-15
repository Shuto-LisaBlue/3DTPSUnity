﻿using System.Collections;
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
    private float LastShot = 0;
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
    // Use this for initialization
    void Start()
    {
        ReticleNoise = ReticleNMin;

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
        }
        if (Input.GetAxis("Reload2P") != 0 && RestBullet != FullBullet)
        {
            RestBullet = 0;
            LastShot = 0;
        }
        if (AutoShot == true)
        {
            if (Input.GetAxis("Fire12P") != 0 && LastShot > Shotrate && RestBullet > 0)
            {
                for (int i = 0; i < Pellet; i++)
                {
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
            }
        }
        else
        {
            if (Input.GetAxis("Fire12P") != 0 && ShotCheck == false && LastShot > Shotrate && RestBullet > 0)
            {
                for (int i = 0; i < Pellet; i++)
                {
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
            }
            else if (Input.GetAxis("Fire12P") == 0) ShotCheck = false;

        }

    }
}