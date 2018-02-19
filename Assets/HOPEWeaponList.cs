using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HOPEWeaponList : MonoBehaviour
{
    public GameObject _AboutText;
    public GameObject _MakerText;
    public bool mode2P;

    public void OnClick()
    {
        _MakerText.GetComponent<Text>().text = "[HOPE]\nアメリカのおもちゃメーカー。\n威力一辺倒の極端なガンが特徴。\n雰囲気とは裏腹に、持ち手には冷静さが要求される";
        if (!mode2P)
        {

            switch (PassesScript.Category1P)
            {
                case 1:
                    _AboutText.GetComponent<Text>().text = "[OOO[No.8]]\nホープ産のアサルトライフル「オーズ」シリーズの一つ。砲身限界の速度でボールを撃ち出す攻撃的なライフル。初弾精度は並だが、レティクルが乱れやすい";
                    PassesScript.Speed1P = 20f;
                    PassesScript.Shotrate1P = 0.12f;
                    PassesScript.RestBullet1P = 20;
                    PassesScript.FullBullet1P = 20;
                    PassesScript.Pellet1P = 1;
                    PassesScript.AutoShot1P = true;
                    PassesScript.ReloadTime1P = 3f;
                    PassesScript.ReticleNMin1P = 0.002f;//いわゆる初弾精度
                    PassesScript.ReticleNMax1P = 0.1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp1P = 0.04f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero1P = 0.003f;//レティクルが元に戻る速度
                    PassesScript.GunLevel1P = 1;//1-4;
                    break;
                case 2:
                    _AboutText.GetComponent<Text>().text = "[DCD[No3]]\nホープ産のショットガン「ディケイド」シリーズの一つ。セミオートではあるが高い発射レートと、SGとしては速い弾速が特長";
                    PassesScript.Speed1P = 14f;
                    PassesScript.Shotrate1P = 0.3f;
                    PassesScript.RestBullet1P = 4;
                    PassesScript.FullBullet1P = 4;
                    PassesScript.Pellet1P = 7;
                    PassesScript.AutoShot1P = false;
                    PassesScript.ReloadTime1P = 3f;
                    PassesScript.ReticleNMin1P = 0.05f;//いわゆる初弾精度
                    PassesScript.ReticleNMax1P = 0.05f;//いわゆる初弾精度
                    PassesScript.ReticletoUp1P = 0.3f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero1P = 0.3f;//レティクルが元に戻る速度
                    PassesScript.GunLevel1P = 1;//1-4;
                    break;
                case 3:
                    _AboutText.GetComponent<Text>().text = "[W[No4]]\nホープのサブマシンガン「ダブル」シリーズの一つ。OOO[No.8]の前身にあたるガンで、その名の通り、マガジンを2つ差し、片方ずつ使用できるのが特徴";
                    PassesScript.Speed1P = 17f;
                    PassesScript.Shotrate1P = 0.12f;
                    PassesScript.RestBullet1P = 15;
                    PassesScript.FullBullet1P = 15;
                    PassesScript.Pellet1P = 1;
                    PassesScript.AutoShot1P = true;
                    PassesScript.ReloadTime1P = 2f;
                    PassesScript.ReticleNMin1P = 0.002f;//いわゆる初弾精度
                    PassesScript.ReticleNMax1P = 0.1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp1P = 0.03f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero1P = 0.004f;//レティクルが元に戻る速度
                    PassesScript.GunLevel1P = 1;//1-4;
                    break;
                case 4:
                    _AboutText.GetComponent<Text>().text = "[555[No5]]\nホープのスナイパーライフル「ファイズ」シリーズの一つ。砲身が二つのダブルバレル方式を採用。瞬時に2発のボールを撃てる代わりに、装填方法が特殊で、リロードに時間がかかる";
                    PassesScript.Speed1P = 45f;
                    PassesScript.Shotrate1P = 0.001f;
                    PassesScript.RestBullet1P = 2;
                    PassesScript.FullBullet1P = 2;
                    PassesScript.Pellet1P = 1;
                    PassesScript.AutoShot1P = true;
                    PassesScript.ReloadTime1P = 3f;
                    PassesScript.ReticleNMin1P = 0.001f;//いわゆる初弾精度
                    PassesScript.ReticleNMax1P = 0.1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp1P = 0.025f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero1P = 0.001f;//レティクルが元に戻る速度
                    PassesScript.GunLevel1P = 1;//1-4;
                    break;

                case 5:
                    _AboutText.GetComponent<Text>().text = "[EX-AID[No1]]\nホープの前衛的作品「エグゼイド」群の一つ。ベースはショットガンだが、SMGに等しい発射レートを持つ。代償として精度が異常に悪いが、目の前に行けば問題ないとは、創設者「ホープ・シュヴェーレン」の言葉";
                    PassesScript.Speed1P = 30f;
                    PassesScript.Shotrate1P = 0.08f;
                    PassesScript.RestBullet1P = 5;
                    PassesScript.FullBullet1P = 5;
                    PassesScript.Pellet1P = 10;
                    PassesScript.AutoShot1P = true;
                    PassesScript.ReloadTime1P = 3.5f;
                    PassesScript.ReticleNMin1P = 0.5f;//いわゆる初弾精度
                    PassesScript.ReticleNMax1P = 1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp1P = 0.025f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero1P = 0.005f;//レティクルが元に戻る速度
                    PassesScript.GunLevel1P = 4;//1-4;
                    break;

            }
        }
        else
        {

            switch (PassesScript.Category2P)
            {
                case 1:
                    _AboutText.GetComponent<Text>().text = "[OOO[No.8]]\nホープ産のアサルトライフル「オーズ」シリーズの一つ。砲身限界の速度でボールを撃ち出す攻撃的なライフル。初弾精度は並だが、レティクルが乱れやすい";
                    PassesScript.Speed2P = 20f;
                    PassesScript.Shotrate2P = 0.12f;
                    PassesScript.RestBullet2P = 20;
                    PassesScript.FullBullet2P = 20;
                    PassesScript.Pellet2P = 1;
                    PassesScript.AutoShot2P = true;
                    PassesScript.ReloadTime2P = 3f;
                    PassesScript.ReticleNMin2P = 0.002f;//いわゆる初弾精度
                    PassesScript.ReticleNMax2P = 0.1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp2P = 0.04f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero2P = 0.003f;//レティクルが元に戻る速度
                    PassesScript.GunLevel2P = 1;//1-4;
                    break;
                case 2:
                    _AboutText.GetComponent<Text>().text = "[DCD[No3]]\nホープ産のショットガン「ディケイド」シリーズの一つ。セミオートではあるが高い発射レートと、SGとしては速い弾速が特長";
                    PassesScript.Speed2P = 14f;
                    PassesScript.Shotrate2P = 0.3f;
                    PassesScript.RestBullet2P = 4;
                    PassesScript.FullBullet2P = 4;
                    PassesScript.Pellet2P = 7;
                    PassesScript.AutoShot2P = false;
                    PassesScript.ReloadTime2P = 3f;
                    PassesScript.ReticleNMin2P = 0.05f;//いわゆる初弾精度
                    PassesScript.ReticleNMax2P = 0.05f;//いわゆる初弾精度
                    PassesScript.ReticletoUp2P = 0.3f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero2P = 0.3f;//レティクルが元に戻る速度
                    PassesScript.GunLevel2P = 1;//1-4;
                    break;
                case 3:
                    _AboutText.GetComponent<Text>().text = "[W[No4]]\nホープのサブマシンガン「ダブル」シリーズの一つ。OOO[No.8]の前身にあたるガンで、その名の通り、マガジンを2つ差し、片方ずつ使用できるのが特徴";
                    PassesScript.Speed2P = 17f;
                    PassesScript.Shotrate2P = 0.12f;
                    PassesScript.RestBullet2P = 15;
                    PassesScript.FullBullet2P = 15;
                    PassesScript.Pellet2P = 1;
                    PassesScript.AutoShot2P = true;
                    PassesScript.ReloadTime2P = 2f;
                    PassesScript.ReticleNMin2P = 0.002f;//いわゆる初弾精度
                    PassesScript.ReticleNMax2P = 0.1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp2P = 0.03f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero2P = 0.004f;//レティクルが元に戻る速度
                    PassesScript.GunLevel2P = 1;//1-4;
                    break;
                case 4:
                    _AboutText.GetComponent<Text>().text = "[555[No5]]\nホープのスナイパーライフル「ファイズ」シリーズの一つ。砲身が二つのダブルバレル方式を採用。瞬時に2発のボールを撃てる代わりに、装填方法が特殊で、リロードに時間がかかる";
                    PassesScript.Speed2P = 45f;
                    PassesScript.Shotrate2P = 0.001f;
                    PassesScript.RestBullet2P = 2;
                    PassesScript.FullBullet2P = 2;
                    PassesScript.Pellet2P = 1;
                    PassesScript.AutoShot2P = true;
                    PassesScript.ReloadTime2P = 3f;
                    PassesScript.ReticleNMin2P = 0.001f;//いわゆる初弾精度
                    PassesScript.ReticleNMax2P = 0.1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp2P = 0.025f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero2P = 0.001f;//レティクルが元に戻る速度
                    PassesScript.GunLevel2P = 1;//1-4;
                    break;

                case 5:
                    _AboutText.GetComponent<Text>().text = "[EX-AID[No1]]\nホープの前衛的作品「エグゼイド」群の一つ。ベースはショットガンだが、SMGに等しい発射レートを持つ。代償として精度が異常に悪いが、目の前に行けば問題ないとは、創設者「ホープ・シュヴェーレン」の言葉";
                    PassesScript.Speed2P = 30f;
                    PassesScript.Shotrate2P = 0.08f;
                    PassesScript.RestBullet2P = 5;
                    PassesScript.FullBullet2P = 5;
                    PassesScript.Pellet2P = 10;
                    PassesScript.AutoShot2P = true;
                    PassesScript.ReloadTime2P = 3.5f;
                    PassesScript.ReticleNMin2P = 0.5f;//いわゆる初弾精度
                    PassesScript.ReticleNMax2P = 1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp2P = 0.025f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero2P = 0.005f;//レティクルが元に戻る速度
                    PassesScript.GunLevel2P = 4;//1-4;
                    break;

            }
        }
    }

}
