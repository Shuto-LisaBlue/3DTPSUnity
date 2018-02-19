using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LindwurmWeaponList : MonoBehaviour
{
    public GameObject _AboutText;
    public GameObject _MakerText;
    public bool mode2P;

    public void OnClick()
    {
        _MakerText.GetComponent<Text>().text = "[リンドヴルム]\nドイツから参入してきた企業。\n他のメーカーとは一線を画す、精度への強いこだわりを持つ。\nその職人気質な作品に惹かれた、コアなファンが多い";
        if (!mode2P)
        {

            switch (PassesScript.Category1P)
            {
                case 1:
                    _AboutText.GetComponent<Text>().text = "[LW/001-HC]\nリンドヴルムの代表作「LW/001」のハイサイクル版。精度をそのままに発射レートを高め、アサルトライフルとしての運用も可能にした。元はLW/001のため、吸着ボールも続投";
                    PassesScript.Speed1P = 30f;
                    PassesScript.Shotrate1P = 0.6f;
                    PassesScript.RestBullet1P = 6;
                    PassesScript.FullBullet1P = 6;
                    PassesScript.Pellet1P = 1;
                    PassesScript.AutoShot1P = true;
                    PassesScript.ReloadTime1P = 1.5f;
                    PassesScript.ReticleNMin1P = 0.0001f;//いわゆる初弾精度
                    PassesScript.ReticleNMax1P = 0.1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp1P = 0.025f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero1P = 0.001f;//レティクルが元に戻る速度
                    PassesScript.GunLevel1P = 2;//1-4;
                    break;
                case 2:
                    _AboutText.GetComponent<Text>().text = "[LW/003]\nリンドヴルム産のショットガン。ショットガンとしては異例の中～長距離戦闘向け。とにかく集弾性のみを追求した、リンドヴルムの意地を感じる逸品。";
                    PassesScript.Speed1P = 20f;
                    PassesScript.Shotrate1P = 0.5f;
                    PassesScript.RestBullet1P = 6;
                    PassesScript.FullBullet1P = 6;
                    PassesScript.Pellet1P = 3;
                    PassesScript.AutoShot1P = false;
                    PassesScript.ReloadTime1P = 4f;
                    PassesScript.ReticleNMin1P = 0.001f;//いわゆる初弾精度
                    PassesScript.ReticleNMax1P = 0.001f;//いわゆる初弾精度
                    PassesScript.ReticletoUp1P = 0.3f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero1P = 0.3f;//レティクルが元に戻る速度
                    PassesScript.GunLevel1P = 1;//1-4;
                    break;
                case 3:
                    _AboutText.GetComponent<Text>().text = "[LW/006-WAM“Pequena“]\nリンドヴルムとアマリエの共作。発射レートと精度の両立を目指し、結果生まれたのは「レーザー」と揶揄されるほどの完璧な両立を実現した名銃だった";
                    PassesScript.Speed1P = 8f;
                    PassesScript.Shotrate1P = 0.08f;
                    PassesScript.RestBullet1P = 20;
                    PassesScript.FullBullet1P = 20;
                    PassesScript.Pellet1P = 1;
                    PassesScript.AutoShot1P = true;
                    PassesScript.ReloadTime1P = 4.2f;
                    PassesScript.ReticleNMin1P = 0.002f;//いわゆる初弾精度
                    PassesScript.ReticleNMax1P = 0.003f;//いわゆる初弾精度
                    PassesScript.ReticletoUp1P = 0.015f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero1P = 0.0025f;//レティクルが元に戻る速度
                    PassesScript.GunLevel1P = 1;//1-4;
                    break;
                case 4:
                    _AboutText.GetComponent<Text>().text = "[LW/001]\nリンドヴルムの処女作にして代表作。トップクラスの弾速と精度を誇る狙撃銃。その弾速のせいで自爆の可能性が高くなったため、壁に吸着し跳弾しないボールを採用している";
                    PassesScript.Speed1P = 50f;
                    PassesScript.Shotrate1P = 1f;
                    PassesScript.RestBullet1P = 3;
                    PassesScript.FullBullet1P = 3;
                    PassesScript.Pellet1P = 1;
                    PassesScript.AutoShot1P = false;
                    PassesScript.ReloadTime1P = 1.5f;
                    PassesScript.ReticleNMin1P = 0.0001f;//いわゆる初弾精度
                    PassesScript.ReticleNMax1P = 0.02f;//いわゆる初弾精度
                    PassesScript.ReticletoUp1P = 0.1f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero1P = 0.004f;//レティクルが元に戻る速度
                    PassesScript.GunLevel1P = 2;//1-4;
                    break;

                case 5:
                    _AboutText.GetComponent<Text>().text = "[LW/010]\nリンドヴルムが社運を賭けて生み出した作品。単発で、凄まじい弾速と精度のボールを撃ち出す。欠点らしい欠点は、リロードの遅さと偶然を許さない吸着ボールの存在。";
                    PassesScript.Speed1P = 100f;
                    PassesScript.Shotrate1P = 0.5f;
                    PassesScript.RestBullet1P = 1;
                    PassesScript.FullBullet1P = 1;
                    PassesScript.Pellet1P = 1;
                    PassesScript.AutoShot1P = true;
                    PassesScript.ReloadTime1P = 6f;
                    PassesScript.ReticleNMin1P = 0.001f;//いわゆる初弾精度
                    PassesScript.ReticleNMax1P = 1f;//いわゆる初弾精度
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
                    _AboutText.GetComponent<Text>().text = "[LW/001-HC]\nリンドヴルムの代表作「LW/001」のハイサイクル版。精度をそのままに発射レートを高め、アサルトライフルとしての運用も可能にした。元はLW/001のため、吸着ボールも続投";
                    PassesScript.Speed2P = 30f;
                    PassesScript.Shotrate2P = 0.6f;
                    PassesScript.RestBullet2P = 6;
                    PassesScript.FullBullet2P = 6;
                    PassesScript.Pellet2P = 1;
                    PassesScript.AutoShot2P = true;
                    PassesScript.ReloadTime2P = 1.5f;
                    PassesScript.ReticleNMin2P = 0.0001f;//いわゆる初弾精度
                    PassesScript.ReticleNMax2P = 0.1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp2P = 0.025f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero2P = 0.001f;//レティクルが元に戻る速度
                    PassesScript.GunLevel2P = 2;//1-4;
                    break;
                case 2:
                    _AboutText.GetComponent<Text>().text = "[LW/003]\nリンドヴルム産のショットガン。ショットガンとしては異例の中～長距離戦闘向け。とにかく集弾性のみを追求した、リンドヴルムの意地を感じる逸品。";
                    PassesScript.Speed2P = 20f;
                    PassesScript.Shotrate2P = 0.5f;
                    PassesScript.RestBullet2P = 6;
                    PassesScript.FullBullet2P = 6;
                    PassesScript.Pellet2P = 3;
                    PassesScript.AutoShot2P = false;
                    PassesScript.ReloadTime2P = 4f;
                    PassesScript.ReticleNMin2P = 0.001f;//いわゆる初弾精度
                    PassesScript.ReticleNMax2P = 0.001f;//いわゆる初弾精度
                    PassesScript.ReticletoUp2P = 0.3f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero2P = 0.3f;//レティクルが元に戻る速度
                    PassesScript.GunLevel2P = 1;//1-4;
                    break;
                case 3:
                    _AboutText.GetComponent<Text>().text = "[LW/006-WAM“Pequena“]\nリンドヴルムとアマリエの共作。発射レートと精度の両立を目指し、結果生まれたのは「レーザー」と揶揄されるほどの完璧な両立を実現した名銃だった";
                    PassesScript.Speed2P = 8f;
                    PassesScript.Shotrate2P = 0.08f;
                    PassesScript.RestBullet2P = 20;
                    PassesScript.FullBullet2P = 20;
                    PassesScript.Pellet2P = 1;
                    PassesScript.AutoShot2P = true;
                    PassesScript.ReloadTime2P = 4.2f;
                    PassesScript.ReticleNMin2P = 0.002f;//いわゆる初弾精度
                    PassesScript.ReticleNMax2P = 0.003f;//いわゆる初弾精度
                    PassesScript.ReticletoUp2P = 0.015f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero2P = 0.0025f;//レティクルが元に戻る速度
                    PassesScript.GunLevel2P = 1;//1-4;
                    break;
                case 4:
                    _AboutText.GetComponent<Text>().text = "[LW/001]\nリンドヴルムの処女作にして代表作。トップクラスの弾速と精度を誇る狙撃銃。その弾速のせいで自爆の可能性が高くなったため、壁に吸着し跳弾しないボールを採用している";
                    PassesScript.Speed2P = 50f;
                    PassesScript.Shotrate2P = 1f;
                    PassesScript.RestBullet2P = 3;
                    PassesScript.FullBullet2P = 3;
                    PassesScript.Pellet2P = 1;
                    PassesScript.AutoShot2P = false;
                    PassesScript.ReloadTime2P = 1.5f;
                    PassesScript.ReticleNMin2P = 0.0001f;//いわゆる初弾精度
                    PassesScript.ReticleNMax2P = 0.02f;//いわゆる初弾精度
                    PassesScript.ReticletoUp2P = 0.1f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero2P = 0.004f;//レティクルが元に戻る速度
                    PassesScript.GunLevel2P = 2;//1-4;
                    break;

                case 5:
                    _AboutText.GetComponent<Text>().text = "[LW/010]\nリンドヴルムが社運を賭けて生み出した作品。単発で、凄まじい弾速と精度のボールを撃ち出す。欠点らしい欠点は、リロードの遅さと偶然を許さない吸着ボールの存在。";
                    PassesScript.Speed2P = 100f;
                    PassesScript.Shotrate2P = 0.5f;
                    PassesScript.RestBullet2P = 1;
                    PassesScript.FullBullet2P = 1;
                    PassesScript.Pellet2P = 1;
                    PassesScript.AutoShot2P = true;
                    PassesScript.ReloadTime2P = 6f;
                    PassesScript.ReticleNMin2P = 0.001f;//いわゆる初弾精度
                    PassesScript.ReticleNMax2P = 1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp2P = 0.025f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero2P = 0.005f;//レティクルが元に戻る速度
                    PassesScript.GunLevel2P = 2;//1-4;
                    break;


            }
        }
    }

}
