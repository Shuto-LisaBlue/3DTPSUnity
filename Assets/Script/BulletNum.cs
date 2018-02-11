using UnityEngine;
using UnityEngine.UI;
using System;

public class BulletNum : MonoBehaviour {
    public GameObject _object;
    ShotBullet _bullet;
    ShotBullet2P _bullet2P;
    public bool Mode2P = false;
    void Start()
    {
        if(Mode2P == false)_bullet = _object.GetComponent<ShotBullet>();
        else _bullet2P = _object.GetComponent<ShotBullet2P>();
    }

    void Update()
    {
        if(Mode2P == false)GetComponent<Text>().text = (_bullet.RestBullet).ToString();
        else GetComponent<Text>().text = (_bullet2P.RestBullet).ToString();
    }
}
