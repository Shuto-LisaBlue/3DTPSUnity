using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndFadeOut : MonoBehaviour {

    public GameObject PC1;
    public GameObject PC2;
    PlayerLife _playerLifePC1;
    PlayerLife _playerLifePC2;
    private float alpha = 0f;
    public static int Winner = 1;

    void Start () {
        _playerLifePC1 = PC1.GetComponent<PlayerLife>();
        _playerLifePC2 = PC2.GetComponent<PlayerLife>();
    }

    // Update is called once per frame
    void Update() {
        if (_playerLifePC1.KnockOut || _playerLifePC2.KnockOut)
        {
            GetComponent<Image>().color = new Color(0f, 0f, 0f, alpha);
            alpha += 0.01f;
        }

        if (_playerLifePC1.KnockOut == true) Winner = 2;
        else if (_playerLifePC2.KnockOut == true) Winner = 1;

        if(alpha >= 1.1)
        {
            //ここにシーン遷移の処理を書く
        }

    }
}
