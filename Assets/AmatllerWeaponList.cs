using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AmatllerWeaponList : MonoBehaviour {
    public GameObject _AboutText;
    public GameObject _MakerText;
    public bool mode2P;

    public void OnClick()
    {
        _MakerText.GetComponent<Text>().text = "[アマリエ]\nSBS主力メーカーでは最も新しい企業。\n総弾数と発射レートの調整による経戦力を重視したガンを開発している";

        if (!mode2P)
        {

            switch (PassesScript.Category1P)
            {
                case 1:
                    _AboutText.GetComponent<Text>().text = "[SAKEISHI]\nレーヴェ産のアサルトライフル。\n高い精度と威力を併せ持つ。\n発射レートを抑えたことで、フルオートであっても精度を保ち続けてくれる名銃";
                    PassesScript.Speed1P = 100.0f;
                    PassesScript.Shotrate1P = 0.5f;
                    PassesScript.LastShot1P = 0;
                    PassesScript.RestBullet1P = 30;
                    PassesScript.FullBullet1P = 30;
                    PassesScript.Pellet1P = 1;
                    PassesScript.AutoShot1P = true;
                    PassesScript.ReloadTime1P = 1.0f;
                    PassesScript.ReticleNoise1P = 0;//レティクルの暴れっぷり
                    PassesScript.ReticleNMin1P = 0.03f;//いわゆる初弾精度
                    PassesScript.ReticleNMax1P = 1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp1P = 0.5f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero1P = 0.005f;//レティクルが元に戻る速度
                    PassesScript.GunLevel1P = 1;//1-4;

                    break;
                case 2:
                    _AboutText.GetComponent<Text>().text = "test";
                    PassesScript.Speed1P = 100.0f;
                    PassesScript.Shotrate1P = 0.5f;
                    PassesScript.LastShot1P = 0;
                    PassesScript.RestBullet1P = 30;
                    PassesScript.FullBullet1P = 30;
                    PassesScript.Pellet1P = 1;
                    PassesScript.AutoShot1P = true;
                    PassesScript.ReloadTime1P = 1.0f;
                    PassesScript.ReticleNoise1P = 0;//レティクルの暴れっぷり
                    PassesScript.ReticleNMin1P = 0.03f;//いわゆる初弾精度
                    PassesScript.ReticleNMax1P = 1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp1P = 0.5f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero1P = 0.003f;//レティクルが元に戻る速度
                    PassesScript.GunLevel1P = 1;//1-4;
                    break;
                case 3:
                    _AboutText.GetComponent<Text>().text = "test";
                    PassesScript.Speed1P = 100.0f;
                    PassesScript.Shotrate1P = 0.5f;
                    PassesScript.LastShot1P = 0;
                    PassesScript.RestBullet1P = 30;
                    PassesScript.FullBullet1P = 30;
                    PassesScript.Pellet1P = 1;
                    PassesScript.AutoShot1P = true;
                    PassesScript.ReloadTime1P = 1.0f;
                    PassesScript.ReticleNoise1P = 0;//レティクルの暴れっぷり
                    PassesScript.ReticleNMin1P = 0.03f;//いわゆる初弾精度
                    PassesScript.ReticleNMax1P = 1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp1P = 0.5f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero1P = 0.003f;//レティクルが元に戻る速度
                    PassesScript.GunLevel1P = 1;//1-4;
                    break;
                case 4:
                    _AboutText.GetComponent<Text>().text = "test";
                    PassesScript.Speed1P = 100.0f;
                    PassesScript.Shotrate1P = 0.5f;
                    PassesScript.LastShot1P = 0;
                    PassesScript.RestBullet1P = 30;
                    PassesScript.FullBullet1P = 30;
                    PassesScript.Pellet1P = 1;
                    PassesScript.AutoShot1P = true;
                    PassesScript.ReloadTime1P = 1.0f;
                    PassesScript.ReticleNoise1P = 0;//レティクルの暴れっぷり
                    PassesScript.ReticleNMin1P = 0.03f;//いわゆる初弾精度
                    PassesScript.ReticleNMax1P = 1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp1P = 0.5f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero1P = 0.003f;//レティクルが元に戻る速度
                    PassesScript.GunLevel1P = 1;//1-4;
                    break;

                case 5:
                    _AboutText.GetComponent<Text>().text = "test";
                    PassesScript.Speed1P = 100.0f;
                    PassesScript.Shotrate1P = 0.5f;
                    PassesScript.LastShot1P = 0;
                    PassesScript.RestBullet1P = 30;
                    PassesScript.FullBullet1P = 30;
                    PassesScript.Pellet1P = 1;
                    PassesScript.AutoShot1P = true;
                    PassesScript.ReloadTime1P = 1.0f;
                    PassesScript.ReticleNoise1P = 0;//レティクルの暴れっぷり
                    PassesScript.ReticleNMin1P = 0.03f;//いわゆる初弾精度
                    PassesScript.ReticleNMax1P = 1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp1P = 0.5f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero1P = 0.003f;//レティクルが元に戻る速度
                    PassesScript.GunLevel1P = 1;//1-4;
                    break;

            }
        }
        else
        {

            switch (PassesScript.Category2P)
            {
                case 1:
                    _AboutText.GetComponent<Text>().text = "[SAKEISHI]\nレーヴェ産のアサルトライフル。\n高い精度と威力を併せ持つ。\n発射レートを抑えたことで、フルオートであっても精度を保ち続けてくれる名銃";
                    PassesScript.Speed2P = 100.0f;
                    PassesScript.Shotrate2P = 0.5f;
                    PassesScript.LastShot2P = 0;
                    PassesScript.RestBullet2P = 30;
                    PassesScript.FullBullet2P = 30;
                    PassesScript.Pellet2P = 1;
                    PassesScript.AutoShot2P = true;
                    PassesScript.ReloadTime2P = 1.0f;
                    PassesScript.ReticleNoise2P = 0;//レティクルの暴れっぷり
                    PassesScript.ReticleNMin2P = 0.03f;//いわゆる初弾精度
                    PassesScript.ReticleNMax2P = 1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp2P = 0.5f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero2P = 0.003f;//レティクルが元に戻る速度
                    PassesScript.GunLevel2P = 1;//1-4;

                    break;
                case 2:
                    _AboutText.GetComponent<Text>().text = "test";
                    PassesScript.Speed2P = 100.0f;
                    PassesScript.Shotrate2P = 0.5f;
                    PassesScript.LastShot2P = 0;
                    PassesScript.RestBullet2P = 30;
                    PassesScript.FullBullet2P = 30;
                    PassesScript.Pellet2P = 1;
                    PassesScript.AutoShot2P = true;
                    PassesScript.ReloadTime2P = 1.0f;
                    PassesScript.ReticleNoise2P = 0;//レティクルの暴れっぷり
                    PassesScript.ReticleNMin2P = 0.03f;//いわゆる初弾精度
                    PassesScript.ReticleNMax2P = 1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp2P = 0.5f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero2P = 0.003f;//レティクルが元に戻る速度
                    PassesScript.GunLevel2P = 1;//1-4;
                    break;
                case 3:
                    _AboutText.GetComponent<Text>().text = "test";
                    PassesScript.Speed2P = 100.0f;
                    PassesScript.Shotrate2P = 0.5f;
                    PassesScript.LastShot2P = 0;
                    PassesScript.RestBullet2P = 30;
                    PassesScript.FullBullet2P = 30;
                    PassesScript.Pellet2P = 1;
                    PassesScript.AutoShot2P = true;
                    PassesScript.ReloadTime2P = 1.0f;
                    PassesScript.ReticleNoise2P = 0;//レティクルの暴れっぷり
                    PassesScript.ReticleNMin2P = 0.03f;//いわゆる初弾精度
                    PassesScript.ReticleNMax2P = 1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp2P = 0.5f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero2P = 0.003f;//レティクルが元に戻る速度
                    PassesScript.GunLevel2P = 1;//1-4;
                    break;
                case 4:
                    _AboutText.GetComponent<Text>().text = "test";
                    PassesScript.Speed2P = 100.0f;
                    PassesScript.Shotrate2P = 0.5f;
                    PassesScript.LastShot2P = 0;
                    PassesScript.RestBullet2P = 30;
                    PassesScript.FullBullet2P = 30;
                    PassesScript.Pellet2P = 1;
                    PassesScript.AutoShot2P = true;
                    PassesScript.ReloadTime2P = 1.0f;
                    PassesScript.ReticleNoise2P = 0;//レティクルの暴れっぷり
                    PassesScript.ReticleNMin2P = 0.03f;//いわゆる初弾精度
                    PassesScript.ReticleNMax2P = 1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp2P = 0.5f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero2P = 0.003f;//レティクルが元に戻る速度
                    PassesScript.GunLevel2P = 1;//1-4;
                    break;

                case 5:
                    _AboutText.GetComponent<Text>().text = "test";
                    PassesScript.Speed2P = 100.0f;
                    PassesScript.Shotrate2P = 0.5f;
                    PassesScript.LastShot2P = 0;
                    PassesScript.RestBullet2P = 30;
                    PassesScript.FullBullet2P = 30;
                    PassesScript.Pellet2P = 1;
                    PassesScript.AutoShot2P = true;
                    PassesScript.ReloadTime2P = 1.0f;
                    PassesScript.ReticleNoise2P = 0;//レティクルの暴れっぷり
                    PassesScript.ReticleNMin2P = 0.03f;//いわゆる初弾精度
                    PassesScript.ReticleNMax2P = 1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp2P = 0.5f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero2P = 0.003f;//レティクルが元に戻る速度
                    PassesScript.GunLevel2P = 1;//1-4;
                    break;

            }
        }
    }

}
