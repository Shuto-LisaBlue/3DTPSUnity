using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushDebugButton : MonoBehaviour
{
    GameObject _object;
    ShotBullet _bullet;
    public float Speed = 100.0f;
    public float Shotrate = 0.5f;
    public float FullBullet = 30;
    public int Pellet = 1;
    public bool AutoShot = true;
    public float ReloadTime = 1.0f;
    public float ReticleNMin = 0.03f;//いわゆる初弾精度
    public float ReticleNMax = 1f;//いわゆる初弾精度
    public float ReticletoUp = 0.5f;//レティクルの暴れる速度
    public float ReticletoZero = 0.003f;//レティクルが元に戻る速度
    public int GunLevel = 1;//1-4;

    void Start()
    {
        _object = GameObject.Find("MainCamera");
        _bullet = _object.GetComponent<ShotBullet>();
    }

    public void OnClick()
    {
        _bullet.Speed = Speed;
        _bullet.Shotrate = Shotrate;
        _bullet.FullBullet = FullBullet;
        _bullet.Pellet = Pellet;
        _bullet.AutoShot = AutoShot;
        _bullet.ReloadTime = ReloadTime;
        _bullet.ReticleNMin = ReticleNMin;
        _bullet.ReticleNMax = ReticleNMax;
        _bullet.ReticletoUp = ReticletoUp;
        _bullet.ReticletoZero = ReticletoZero;
        _bullet.GunLevel = GunLevel;
        Debug.Log("Set Rifle");
    }
}