using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ReticleOvered : MonoBehaviour {
    private Vector3 pos;
    public bool Mirror = false;
    GameObject _object;
    ShotBullet _bullet;
    private GameObject _gameObject;
    void Start()
    {
       pos = GetComponent<RectTransform>().localPosition;
        _object = GameObject.Find("MainCamera");
        _bullet = _object.GetComponent<ShotBullet>();
    }

    void Update () {
        if(Mirror == true) pos = new Vector3(_bullet.ReticleNoise * 100, -10.0f, 0f);
        else pos = new Vector3(_bullet.ReticleNoise * -100, -10.0f, 0f);
        GetComponent<RectTransform>().localPosition = pos;
    }
}
