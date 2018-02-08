﻿using UnityEngine;
using UnityEngine.UI;
using System;

public class BulletNum : MonoBehaviour {
    public GameObject _object;
    ShotBullet _bullet;
    void Start()
    {
        _bullet = _object.GetComponent<ShotBullet>();
    }

    void Update()
    {
        GetComponent<Text>().text = (_bullet.RestBullet).ToString();
    }
}
