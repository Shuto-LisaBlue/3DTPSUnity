using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LisaricciaWeaponList : MonoBehaviour
{
    public GameObject _AboutText;
    public GameObject _MakerText;
    public bool mode2P;

    public void OnClick()
    {
        _MakerText.GetComponent<Text>().text = "[リサリシア]\n近年、突如SBSに流通し始めたメーカー。\n「茨の檻に入った薔薇」というマークはあるものの、どこで作られているかは不明。「リサリシア」という名前も自然とそう呼ばれているだけで、詳細は不明。\nだがきちんとレギュレーションには沿っているため、使用が許可されている";

        if (!mode2P)
        {

            switch (PassesScript.Category1P)
            {
                case 1:
                    _AboutText.GetComponent<Text>().text = "[Rodon]\nリサリシアのアサルトライフル。初弾精度が極めて高いものの、リロードをするまで精度が回復しない奇妙な性質を持つ";
                    PassesScript.Speed1P = 20f;
                    PassesScript.Shotrate1P = 0.1f;
                    PassesScript.RestBullet1P = 30;
                    PassesScript.FullBullet1P = 30;
                    PassesScript.Pellet1P = 1;
                    PassesScript.AutoShot1P = true;
                    PassesScript.ReloadTime1P = 3f;
                    PassesScript.ReticleNMin1P = 0f;//いわゆる初弾精度
                    PassesScript.ReticleNMax1P = 1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp1P = 0.005f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero1P = 0f;//レティクルが元に戻る速度
                    PassesScript.GunLevel1P = 1;//1-4;
                    break;
                case 2:
                    _AboutText.GetComponent<Text>().text = "[Bungaros]\nリサリシアのショットガン。発射後0.3秒で拡散する奇妙な性質を持つ";
                    PassesScript.Speed1P = 10f;
                    PassesScript.Shotrate1P = 0.5f;
                    PassesScript.RestBullet1P = 6;
                    PassesScript.FullBullet1P = 6;
                    PassesScript.Pellet1P = 3;
                    PassesScript.AutoShot1P = true;
                    PassesScript.ReloadTime1P = 4f;
                    PassesScript.ReticleNMin1P = 0.001f;//いわゆる初弾精度
                    PassesScript.ReticleNMax1P = 0.05f;//いわゆる初弾精度
                    PassesScript.ReticletoUp1P = 0.2f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero1P = 0.0025f;//レティクルが元に戻る速度
                    PassesScript.GunLevel1P = 5;//1-4;
                    break;
                case 3:
                    _AboutText.GetComponent<Text>().text = "[Rosier]\nリサリシアのサブマシンガン。一切精度が変化しない、奇妙な性質を持つ";
                    PassesScript.Speed1P = 20f;
                    PassesScript.Shotrate1P = 0.05f;
                    PassesScript.RestBullet1P = 30;
                    PassesScript.FullBullet1P = 30;
                    PassesScript.Pellet1P = 1;
                    PassesScript.AutoShot1P = true;
                    PassesScript.ReloadTime1P = 3f;
                    PassesScript.ReticleNMin1P = 0.05f;//いわゆる初弾精度
                    PassesScript.ReticleNMax1P = 0.05f;//いわゆる初弾精度
                    PassesScript.ReticletoUp1P = 0.005f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero1P = 0f;//レティクルが元に戻る速度
                    PassesScript.GunLevel1P = 1;//1-4;
                    break;
                case 4:
                    _AboutText.GetComponent<Text>().text = "[Veled]\nリサリシアのスナイパーライフル。ボールが重力の影響を受けない、奇妙な性質を持つ";
                    PassesScript.Speed1P = 40f;
                    PassesScript.Shotrate1P = 0.5f;
                    PassesScript.RestBullet1P = 6;
                    PassesScript.FullBullet1P = 6;
                    PassesScript.Pellet1P = 1;
                    PassesScript.AutoShot1P = false;
                    PassesScript.ReloadTime1P = 4f;
                    PassesScript.ReticleNMin1P = 0.001f;//いわゆる初弾精度
                    PassesScript.ReticleNMax1P = 0.05f;//いわゆる初弾精度
                    PassesScript.ReticletoUp1P = 0.05f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero1P = 0.002f;//レティクルが元に戻る速度
                    PassesScript.GunLevel1P = 6;//1-4;
                    break;

                case 5:
                    _AboutText.GetComponent<Text>().text = "[Trianhaphylloiha]\n詳細不明。銃身に「我が愛しのトゥリアンに捧ぐ」と彫られている";
                    PassesScript.Speed1P = 10f;
                    PassesScript.Shotrate1P = 0.1f;
                    PassesScript.RestBullet1P = 1;
                    PassesScript.FullBullet1P = 1;
                    PassesScript.Pellet1P = 1;
                    PassesScript.AutoShot1P = true;
                    PassesScript.ReloadTime1P = 10f;
                    PassesScript.ReticleNMin1P = 0.001f;//いわゆる初弾精度
                    PassesScript.ReticleNMax1P = 0.05f;//いわゆる初弾精度
                    PassesScript.ReticletoUp1P = 0.02f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero1P = 0.0025f;//レティクルが元に戻る速度
                    PassesScript.GunLevel1P = 7;//1-4;
                    break;

            }
        }
        else
        {

            switch (PassesScript.Category2P)
            {
                case 1:
                    _AboutText.GetComponent<Text>().text = "[Rodon]\nリサリシアのアサルトライフル。初弾精度が極めて高いものの、リロードをするまで精度が回復しない奇妙な性質を持つ";
                    PassesScript.Speed2P = 20f;
                    PassesScript.Shotrate2P = 0.1f;
                    PassesScript.RestBullet2P = 30;
                    PassesScript.FullBullet2P = 30;
                    PassesScript.Pellet2P = 1;
                    PassesScript.AutoShot2P = true;
                    PassesScript.ReloadTime2P = 3f;
                    PassesScript.ReticleNMin2P = 0f;//いわゆる初弾精度
                    PassesScript.ReticleNMax2P = 1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp2P = 0.005f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero2P = 0f;//レティクルが元に戻る速度
                    PassesScript.GunLevel2P = 1;//1-4;
                    break;
                case 2:
                    _AboutText.GetComponent<Text>().text = "[Bungaros]\nリサリシアのショットガン。発射後0.3秒で拡散する奇妙な性質を持つ";
                    PassesScript.Speed2P = 10f;
                    PassesScript.Shotrate2P = 0.5f;
                    PassesScript.RestBullet2P = 6;
                    PassesScript.FullBullet2P = 6;
                    PassesScript.Pellet2P = 3;
                    PassesScript.AutoShot2P = true;
                    PassesScript.ReloadTime2P = 4f;
                    PassesScript.ReticleNMin2P = 0.001f;//いわゆる初弾精度
                    PassesScript.ReticleNMax2P = 0.05f;//いわゆる初弾精度
                    PassesScript.ReticletoUp2P = 0.2f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero2P = 0.0025f;//レティクルが元に戻る速度
                    PassesScript.GunLevel2P = 5;//1-4;
                    break;
                case 3:
                    _AboutText.GetComponent<Text>().text = "[Rosier]\nリサリシアのサブマシンガン。一切精度が変化しない、奇妙な性質を持つ";
                    PassesScript.Speed2P = 20f;
                    PassesScript.Shotrate2P = 0.05f;
                    PassesScript.RestBullet2P = 30;
                    PassesScript.FullBullet2P = 30;
                    PassesScript.Pellet2P = 1;
                    PassesScript.AutoShot2P = true;
                    PassesScript.ReloadTime2P = 3f;
                    PassesScript.ReticleNMin2P = 0.05f;//いわゆる初弾精度
                    PassesScript.ReticleNMax2P = 0.05f;//いわゆる初弾精度
                    PassesScript.ReticletoUp2P = 0.005f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero2P = 0f;//レティクルが元に戻る速度
                    PassesScript.GunLevel2P = 1;//1-4;
                    break;
                case 4:
                    _AboutText.GetComponent<Text>().text = "[Veled]\nリサリシアのスナイパーライフル。ボールが重力の影響を受けない、奇妙な性質を持つ";
                    PassesScript.Speed2P = 40f;
                    PassesScript.Shotrate2P = 0.5f;
                    PassesScript.RestBullet2P = 6;
                    PassesScript.FullBullet2P = 6;
                    PassesScript.Pellet2P = 1;
                    PassesScript.AutoShot2P = false;
                    PassesScript.ReloadTime2P = 4f;
                    PassesScript.ReticleNMin2P = 0.001f;//いわゆる初弾精度
                    PassesScript.ReticleNMax2P = 0.05f;//いわゆる初弾精度
                    PassesScript.ReticletoUp2P = 0.05f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero2P = 0.002f;//レティクルが元に戻る速度
                    PassesScript.GunLevel2P = 6;//1-4;
                    break;

                case 5:
                    _AboutText.GetComponent<Text>().text = "[Trianhaphylloiha]\n詳細不明。銃身に「我が愛しのトゥリアンに捧ぐ」と彫られている";
                    PassesScript.Speed2P = 10f;
                    PassesScript.Shotrate2P = 0.1f;
                    PassesScript.RestBullet2P = 1;
                    PassesScript.FullBullet2P = 1;
                    PassesScript.Pellet2P = 1;
                    PassesScript.AutoShot2P = true;
                    PassesScript.ReloadTime2P = 10f;
                    PassesScript.ReticleNMin2P = 0.001f;//いわゆる初弾精度
                    PassesScript.ReticleNMax2P = 0.05f;//いわゆる初弾精度
                    PassesScript.ReticletoUp2P = 0.02f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero2P = 0.0025f;//レティクルが元に戻る速度
                    PassesScript.GunLevel2P = 7;//1-4;
                    break;

            }
        }
    }

}
