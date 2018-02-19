using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeweWeaponList : MonoBehaviour
{
    public GameObject _AboutText;
    public GameObject _MakerText;
    public bool mode2P;

    public void OnClick()
    {
        _MakerText.GetComponent<Text>().text = "[レーヴェ]\nSBSを設立した企業。公式大会の運営も務める。\n初めてSBSをプレイするユーザー向けの扱い易いガンを扱っている。\n最初はレーヴェから選ぶのがオススメ";

        if (!mode2P)
        {

            switch (PassesScript.Category1P)
            {
                case 1:
                    _AboutText.GetComponent<Text>().text = "[SAKEISHI]\nレーヴェ産のアサルトライフル。\n高い精度と威力を併せ持つ。\n発射レートを抑えたことで、フルオートであっても精度を保ち続けてくれる名銃";
                    PassesScript.Speed1P = 10.0f;
                    PassesScript.Shotrate1P = 0.1f;
                    PassesScript.LastShot1P = 0;
                    PassesScript.RestBullet1P = 30;
                    PassesScript.FullBullet1P = 30;
                    PassesScript.Pellet1P = 1;
                    PassesScript.AutoShot1P = true;
                    PassesScript.ReloadTime1P = 2.5f;
                    PassesScript.ReticleNoise1P = 0;//レティクルの暴れっぷり
                    PassesScript.ReticleNMin1P = 0.001f;//いわゆる初弾精度
                    PassesScript.ReticleNMax1P = 0.05f;//いわゆる初弾精度
                    PassesScript.ReticletoUp1P = 0.02f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero1P = 0.0025f;//レティクルが元に戻る速度
                    PassesScript.GunLevel1P = 1;//1-4;

                    break;
                case 2:
                    _AboutText.GetComponent<Text>().text = "[RAUSU]\nレーヴェ産のショットガン。1度に複数発のボールを撃つ。\n弾速は抑えられているものの、ペレット数に優れ、命中率は高い";
                    PassesScript.Speed1P = 8.0f;
                    PassesScript.Shotrate1P = 0.5f;
                    PassesScript.LastShot1P = 0;
                    PassesScript.RestBullet1P = 6;
                    PassesScript.FullBullet1P = 6;
                    PassesScript.Pellet1P = 15;
                    PassesScript.AutoShot1P = false;
                    PassesScript.ReloadTime1P = 2.5f;
                    PassesScript.ReticleNoise1P = 0;//レティクルの暴れっぷり
                    PassesScript.ReticleNMin1P = 0.002f;//いわゆる初弾精度
                    PassesScript.ReticleNMax1P = 0.1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp1P = 0.02f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero1P = 0.0025f;//レティクルが元に戻る速度
                    PassesScript.GunLevel1P = 1;//1-4;
                    break;
                case 3:
                    _AboutText.GetComponent<Text>().text = "[HYAKUANA]\nレーヴェ産のサブマシンガン。随一の発射レートを誇る。SAKEISHIとは違い、発射レートに重きを置いた作り。度重なる調整により、扱い易い性能に落ち着いた";
                    PassesScript.Speed1P = 8.0f;
                    PassesScript.Shotrate1P = 0.05f;
                    PassesScript.LastShot1P = 0;
                    PassesScript.RestBullet1P = 30;
                    PassesScript.FullBullet1P = 30;
                    PassesScript.Pellet1P = 1;
                    PassesScript.AutoShot1P = true;
                    PassesScript.ReloadTime1P = 2.5f;
                    PassesScript.ReticleNoise1P = 0;//レティクルの暴れっぷり
                    PassesScript.ReticleNMin1P = 0.05f;//いわゆる初弾精度
                    PassesScript.ReticleNMax1P = 0.05f;//いわゆる初弾精度
                    PassesScript.ReticletoUp1P = 0.015f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero1P = 0.0025f;//レティクルが元に戻る速度
                    PassesScript.GunLevel1P = 1;//1-4;
                    break;
                case 4:
                    _AboutText.GetComponent<Text>().text = "[NIGORIGO]\nレーヴェ産のスナイパーライフル。SBSでは、弾丸ではなくボールを撃つため精度が低く、スナイパーライフルであってもスコープを搭載しないことが多い";
                    PassesScript.Speed1P = 40.0f;
                    PassesScript.Shotrate1P = 0.5f;
                    PassesScript.LastShot1P = 0;
                    PassesScript.RestBullet1P = 5;
                    PassesScript.FullBullet1P = 5;
                    PassesScript.Pellet1P = 1;
                    PassesScript.AutoShot1P = false;
                    PassesScript.ReloadTime1P = 2.5f;
                    PassesScript.ReticleNoise1P = 0;//レティクルの暴れっぷり
                    PassesScript.ReticleNMin1P = 0.001f;//いわゆる初弾精度
                    PassesScript.ReticleNMax1P = 0.05f;//いわゆる初弾精度
                    PassesScript.ReticletoUp1P = 0.07f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero1P = 0.001f;//レティクルが元に戻る速度
                    PassesScript.GunLevel1P = 1;//1-4;
                    break;

                case 5:
                    _AboutText.GetComponent<Text>().text = "[KUSATSU]\nレーヴェ産のグレネードランチャー。壁に吸着し、一定時間後に180発のボールを周囲にばらまく。試作時のコードネームは「ストレートアングル」その豪快さとは裏腹に、命中率は非常に悪く、直撃を狙ったほうがいいと本末転倒な評価を受ける";
                    PassesScript.Speed1P = 10f;
                    PassesScript.Shotrate1P = 0.1f;
                    PassesScript.LastShot1P = 0;
                    PassesScript.RestBullet1P = 1;
                    PassesScript.FullBullet1P = 1;
                    PassesScript.Pellet1P = 1;
                    PassesScript.AutoShot1P = true;
                    PassesScript.ReloadTime1P = 4f;
                    PassesScript.ReticleNoise1P = 0;//レティクルの暴れっぷり
                    PassesScript.ReticleNMin1P = 0.001f;//いわゆる初弾精度
                    PassesScript.ReticleNMax1P = 0.01f;//いわゆる初弾精度
                    PassesScript.ReticletoUp1P = 0.025f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero1P = 0.001f;//レティクルが元に戻る速度
                    PassesScript.GunLevel1P = 3;//1-4;
                    break;

            }
        }
        else
        {

            switch (PassesScript.Category2P)
            {
                case 1:
                    _AboutText.GetComponent<Text>().text = "[SAKEISHI]\nレーヴェ産のアサルトライフル。\n高い精度と威力を併せ持つ。\n発射レートを抑えたことで、フルオートであっても精度を保ち続けてくれる名銃";
                    PassesScript.Speed2P = 10.0f;
                    PassesScript.Shotrate2P = 0.1f;
                    PassesScript.LastShot2P = 0;
                    PassesScript.RestBullet2P = 30;
                    PassesScript.FullBullet2P = 30;
                    PassesScript.Pellet2P = 1;
                    PassesScript.AutoShot2P = true;
                    PassesScript.ReloadTime2P = 2.5f;
                    PassesScript.ReticleNoise2P = 0;//レティクルの暴れっぷり
                    PassesScript.ReticleNMin2P = 0.001f;//いわゆる初弾精度
                    PassesScript.ReticleNMax2P = 0.05f;//いわゆる初弾精度
                    PassesScript.ReticletoUp2P = 0.02f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero2P = 0.0025f;//レティクルが元に戻る速度
                    PassesScript.GunLevel2P = 1;//1-4;

                    break;
                case 2:
                    _AboutText.GetComponent<Text>().text = "[RAUSU]\nレーヴェ産のショットガン。1度に複数発のボールを撃つ。\n弾速は抑えられているものの、ペレット数に優れ、命中率は高い";
                    PassesScript.Speed2P = 8.0f;
                    PassesScript.Shotrate2P = 0.5f;
                    PassesScript.LastShot2P = 0;
                    PassesScript.RestBullet2P = 6;
                    PassesScript.FullBullet2P = 6;
                    PassesScript.Pellet2P = 15;
                    PassesScript.AutoShot2P = false;
                    PassesScript.ReloadTime2P = 2.5f;
                    PassesScript.ReticleNoise2P = 0;//レティクルの暴れっぷり
                    PassesScript.ReticleNMin2P = 0.002f;//いわゆる初弾精度
                    PassesScript.ReticleNMax2P = 0.1f;//いわゆる初弾精度
                    PassesScript.ReticletoUp2P = 0.02f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero2P = 0.0025f;//レティクルが元に戻る速度
                    PassesScript.GunLevel2P = 1;//1-4;
                    break;
                case 3:
                    _AboutText.GetComponent<Text>().text = "[HYAKUANA]\nレーヴェ産のサブマシンガン。随一の発射レートを誇る。SAKEISHIとは違い、発射レートに重きを置いた作り。度重なる調整により、扱い易い性能に落ち着いた";
                    PassesScript.Speed2P = 8.0f;
                    PassesScript.Shotrate2P = 0.05f;
                    PassesScript.LastShot2P = 0;
                    PassesScript.RestBullet2P = 30;
                    PassesScript.FullBullet2P = 30;
                    PassesScript.Pellet2P = 1;
                    PassesScript.AutoShot2P = true;
                    PassesScript.ReloadTime2P = 2.5f;
                    PassesScript.ReticleNoise2P = 0;//レティクルの暴れっぷり
                    PassesScript.ReticleNMin2P = 0.05f;//いわゆる初弾精度
                    PassesScript.ReticleNMax2P = 0.05f;//いわゆる初弾精度
                    PassesScript.ReticletoUp2P = 0.015f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero2P = 0.0025f;//レティクルが元に戻る速度
                    PassesScript.GunLevel2P = 1;//1-4;
                    break;
                case 4:
                    _AboutText.GetComponent<Text>().text = "[NIGORIGO]\nレーヴェ産のスナイパーライフル。SBSでは、弾丸ではなくボールを撃つため精度が低く、スナイパーライフルであってもスコープを搭載しないことが多い";
                    PassesScript.Speed2P = 40.0f;
                    PassesScript.Shotrate2P = 0.5f;
                    PassesScript.LastShot2P = 0;
                    PassesScript.RestBullet2P = 5;
                    PassesScript.FullBullet2P = 5;
                    PassesScript.Pellet2P = 1;
                    PassesScript.AutoShot2P = false;
                    PassesScript.ReloadTime2P = 2.5f;
                    PassesScript.ReticleNoise2P = 0;//レティクルの暴れっぷり
                    PassesScript.ReticleNMin2P = 0.001f;//いわゆる初弾精度
                    PassesScript.ReticleNMax2P = 0.05f;//いわゆる初弾精度
                    PassesScript.ReticletoUp2P = 0.07f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero2P = 0.001f;//レティクルが元に戻る速度
                    PassesScript.GunLevel2P = 1;//1-4;
                    break;

                case 5:
                    _AboutText.GetComponent<Text>().text = "[KUSATSU]\nレーヴェ産のグレネードランチャー。壁に吸着し、一定時間後に180発のボールを周囲にばらまく。試作時のコードネームは「ストレートアングル」その豪快さとは裏腹に、命中率は非常に悪く、直撃を狙ったほうがいいと本末転倒な評価を受ける";
                    PassesScript.Speed2P = 10f;
                    PassesScript.Shotrate2P = 0.1f;
                    PassesScript.LastShot2P = 0;
                    PassesScript.RestBullet2P = 1;
                    PassesScript.FullBullet2P = 1;
                    PassesScript.Pellet2P = 1;
                    PassesScript.AutoShot2P = true;
                    PassesScript.ReloadTime2P = 4f;
                    PassesScript.ReticleNoise2P = 0;//レティクルの暴れっぷり
                    PassesScript.ReticleNMin2P = 0.001f;//いわゆる初弾精度
                    PassesScript.ReticleNMax2P = 0.01f;//いわゆる初弾精度
                    PassesScript.ReticletoUp2P = 0.025f;//レティクルの暴れる速度
                    PassesScript.ReticletoZero2P = 0.001f;//レティクルが元に戻る速度
                    PassesScript.GunLevel2P = 3;//1-4;
                    break;

            }

        }
    }
}
