using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AmatllerWeaponList : MonoBehaviour
{
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
                    _AboutText.GetComponent<Text>().text = "[GGN-9”Spica”]\nアマリエ産のアサルトライフル。大きめのマガジンと、精度を保てる低い発射レートにより、高い経戦力を実現した名作。";
                    PassesScript.Speed1P = 9f;
                    PassesScript.Shotrate1P = 0.15f;
                    PassesScript.RestBullet1P = 50;
                    PassesScript.FullBullet1P = 50;
                    PassesScript.Pellet1P = 1;
                    PassesScript.AutoShot1P = true;
                    PassesScript.ReloadTime1P = 3f;
                    PassesScript.ReticleNMin1P = 0.001f;//いわゆる初弾精度
                    PassesScript.ReticleNMax1P = 0.1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp1P = 0.03f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero1P = 0.0025f;//レティクルが元に戻る速度
                    PassesScript.GunLevel1P = 1;//1-4;
                    break;
                case 2:
                    _AboutText.GetComponent<Text>().text = "[SSH-53”Sirio”]\nアマリエ産のショットガン。SGでは珍しくフルオート発射が可能。ペレット数は控えめだが、面の制圧力に長ける";
                    PassesScript.Speed1P = 8f;
                    PassesScript.Shotrate1P = 0.5f;
                    PassesScript.RestBullet1P = 10;
                    PassesScript.FullBullet1P = 10;
                    PassesScript.Pellet1P = 8;
                    PassesScript.AutoShot1P = true;
                    PassesScript.ReloadTime1P = 4f;
                    PassesScript.ReticleNMin1P = 0.002f;//いわゆる初弾精度
                    PassesScript.ReticleNMax1P = 0.1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp1P = 0.02f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero1P = 0.0025f;//レティクルが元に戻る速度
                    PassesScript.GunLevel1P = 1;//1-4;
                    break;
                case 3:
                    _AboutText.GetComponent<Text>().text = "[SSU-24”Deneb”]\nアマリエ産のサブマシンガン。業界一のマガジン技術を遺憾なく発揮した一丁。至近距離での戦闘力は非常に高い";
                    PassesScript.Speed1P = 7f;
                    PassesScript.Shotrate1P = 0.07f;
                    PassesScript.RestBullet1P = 50;
                    PassesScript.FullBullet1P = 50;
                    PassesScript.Pellet1P = 1;
                    PassesScript.AutoShot1P = true;
                    PassesScript.ReloadTime1P = 4.5f;
                    PassesScript.ReticleNMin1P = 0.002f;//いわゆる初弾精度
                    PassesScript.ReticleNMax1P = 0.05f;//いわゆる初弾精度
                    PassesScript.ReticletoUp1P = 0.015f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero1P = 0.0025f;//レティクルが元に戻る速度
                    PassesScript.GunLevel1P = 1;//1-4;
                    break;
                case 4:
                    _AboutText.GetComponent<Text>().text = "[SSN-54“Vega“]\n大型マガジンを採用したアマリエのSR。発射レートと精度はSRの水準ではあるが、着弾が遅く、相手の動きを読む想像力、あるいは思い切りの良さが大事になる";
                    PassesScript.Speed1P = 25f;
                    PassesScript.Shotrate1P = 0.5f;
                    PassesScript.RestBullet1P = 12;
                    PassesScript.FullBullet1P = 12;
                    PassesScript.Pellet1P = 1;
                    PassesScript.AutoShot1P = false;
                    PassesScript.ReloadTime1P = 2.5f;
                    PassesScript.ReticleNMin1P = 0.002f;//いわゆる初弾精度
                    PassesScript.ReticleNMax1P = 0.5f;//いわゆる初弾精度
                    PassesScript.ReticletoUp1P = 0.1f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero1P = 0.004f;//レティクルが元に戻る速度
                    PassesScript.GunLevel1P = 1;//1-4;
                    break;

                case 5:
                    _AboutText.GetComponent<Text>().text = "[GGT-9”Spica”]\nアマリエの誇る試作ガトリングガン。超大型マガジンに、焼き切れんばかりの発射レートを組み合わせた、至高の一品。トリガーハッピーなユーザーに。";
                    PassesScript.Speed1P = 10f;
                    PassesScript.Shotrate1P = 0.01f;
                    PassesScript.RestBullet1P = 99;
                    PassesScript.FullBullet1P = 99;
                    PassesScript.Pellet1P = 1;
                    PassesScript.AutoShot1P = true;
                    PassesScript.ReloadTime1P = 6f;
                    PassesScript.ReticleNMin1P = 0.001f;//いわゆる初弾精度
                    PassesScript.ReticleNMax1P = 0.1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp1P = 0.025f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero1P = 0.005f;//レティクルが元に戻る速度
                    PassesScript.GunLevel1P = 2;//1-4;
                    break;

            }
        }
        else
        {

            switch (PassesScript.Category2P)
            {
                case 1:
                    _AboutText.GetComponent<Text>().text = "[GGN-9”Spica”]\nアマリエ産のアサルトライフル。大きめのマガジンと、精度を保てる低い発射レートにより、高い経戦力を実現した名作。";
                    PassesScript.Speed2P = 9f;
                    PassesScript.Shotrate2P = 0.15f;
                    PassesScript.RestBullet2P = 50;
                    PassesScript.FullBullet2P = 50;
                    PassesScript.Pellet2P = 1;
                    PassesScript.AutoShot2P = true;
                    PassesScript.ReloadTime2P = 3f;
                    PassesScript.ReticleNMin2P = 0.001f;//いわゆる初弾精度
                    PassesScript.ReticleNMax2P = 0.1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp2P = 0.03f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero2P = 0.0025f;//レティクルが元に戻る速度
                    PassesScript.GunLevel2P = 1;//1-4;
                    break;
                case 2:
                    _AboutText.GetComponent<Text>().text = "[SSH-53”Sirio”]\nアマリエ産のショットガン。SGでは珍しくフルオート発射が可能。ペレット数は控えめだが、面の制圧力に長ける";
                    PassesScript.Speed2P = 8f;
                    PassesScript.Shotrate2P = 0.5f;
                    PassesScript.RestBullet2P = 10;
                    PassesScript.FullBullet2P = 10;
                    PassesScript.Pellet2P = 8;
                    PassesScript.AutoShot2P = true;
                    PassesScript.ReloadTime2P = 4f;
                    PassesScript.ReticleNMin2P = 0.002f;//いわゆる初弾精度
                    PassesScript.ReticleNMax2P = 0.1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp2P = 0.02f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero2P = 0.0025f;//レティクルが元に戻る速度
                    PassesScript.GunLevel2P = 1;//1-4;
                    break;
                case 3:
                    _AboutText.GetComponent<Text>().text = "[SSU-24”Deneb”]\nアマリエ産のサブマシンガン。業界一のマガジン技術を遺憾なく発揮した一丁。至近距離での戦闘力は非常に高い";
                    PassesScript.Speed2P = 7f;
                    PassesScript.Shotrate2P = 0.07f;
                    PassesScript.RestBullet2P = 50;
                    PassesScript.FullBullet2P = 50;
                    PassesScript.Pellet2P = 1;
                    PassesScript.AutoShot2P = true;
                    PassesScript.ReloadTime2P = 4.5f;
                    PassesScript.ReticleNMin2P = 0.002f;//いわゆる初弾精度
                    PassesScript.ReticleNMax2P = 0.05f;//いわゆる初弾精度
                    PassesScript.ReticletoUp2P = 0.015f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero2P = 0.0025f;//レティクルが元に戻る速度
                    PassesScript.GunLevel2P = 1;//1-4;
                    break;
                case 4:
                    _AboutText.GetComponent<Text>().text = "[SSN-54“Vega“]\n大型マガジンを採用したアマリエのSR。発射レートと精度はSRの水準ではあるが、着弾が遅く、相手の動きを読む想像力、あるいは思い切りの良さが大事になる";
                    PassesScript.Speed2P = 25f;
                    PassesScript.Shotrate2P = 0.5f;
                    PassesScript.RestBullet2P = 12;
                    PassesScript.FullBullet2P = 12;
                    PassesScript.Pellet2P = 1;
                    PassesScript.AutoShot2P = false;
                    PassesScript.ReloadTime2P = 2.5f;
                    PassesScript.ReticleNMin2P = 0.002f;//いわゆる初弾精度
                    PassesScript.ReticleNMax2P = 0.5f;//いわゆる初弾精度
                    PassesScript.ReticletoUp2P = 0.1f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero2P = 0.004f;//レティクルが元に戻る速度
                    PassesScript.GunLevel2P = 1;//1-4;
                    break;

                case 5:
                    _AboutText.GetComponent<Text>().text = "[GGT-9”Spica”]\nアマリエの誇る試作ガトリングガン。超大型マガジンに、焼き切れんばかりの発射レートを組み合わせた、至高の一品。トリガーハッピーなユーザーに。";
                    PassesScript.Speed2P = 10f;
                    PassesScript.Shotrate2P = 0.01f;
                    PassesScript.RestBullet2P = 99;
                    PassesScript.FullBullet2P = 99;
                    PassesScript.Pellet2P = 1;
                    PassesScript.AutoShot2P = true;
                    PassesScript.ReloadTime2P = 6f;
                    PassesScript.ReticleNMin2P = 0.001f;//いわゆる初弾精度
                    PassesScript.ReticleNMax2P = 0.1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp2P = 0.025f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero2P = 0.005f;//レティクルが元に戻る速度
                    PassesScript.GunLevel2P = 2;//1-4;
                    break;

            }
        }
    }

}
