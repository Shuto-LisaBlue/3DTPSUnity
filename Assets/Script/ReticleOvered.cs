using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ReticleOvered : MonoBehaviour
{
    private Vector3 pos;
    public bool Mirror = false;
    public bool mode2P = false;
    GameObject _object;
    ShotBullet _bullet;
    ShotBullet2P _bullet2P;
    private GameObject _gameObject;
    void Start()
    {
        pos = GetComponent<RectTransform>().localPosition;
        if (mode2P == false)
        {
            _object = GameObject.Find("MainCamera");
            _bullet = _object.GetComponent<ShotBullet>();
        }
        else
        {
            _object = GameObject.Find("2PCamera");
            _bullet2P = _object.GetComponent<ShotBullet2P>();
        }
    }

    void Update()
    {
        if (mode2P == false)
        {
            if (Mirror == true) pos = new Vector3(-252.5f + (_bullet.ReticleNoise * 100), -10.0f, 0f);
            else pos = new Vector3(-252.5f + (_bullet.ReticleNoise * -100), -10.0f, 0f);
        }
        else
        {
            if (Mirror == true) pos = new Vector3(252.5f + (_bullet2P.ReticleNoise * 100), -10.0f, 0f);
            else pos = new Vector3(252.5f + (_bullet2P.ReticleNoise * -100), -10.0f, 0f);

        }

        GetComponent<RectTransform>().localPosition = pos;
    }
}
