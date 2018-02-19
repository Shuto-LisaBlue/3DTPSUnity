using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassesScript : MonoBehaviour
{
    public static int Category1P = 0;
    public static float Speed1P = 10.0f;
    public static float Shotrate1P = 0.1f;
    public static float LastShot1P = 0;
    public static float RestBullet1P = 30;
    public static float FullBullet1P = 30;
    public static int Pellet1P = 1;
    public static bool AutoShot1P = true;
    public static float ReloadTime1P = 2.5f;
    public static float ReticleNoise1P = 0;//レティクルの暴れっぷり
    public static float ReticleNMin1P = 0.001f;//いわゆる初弾精度
    public static float ReticleNMax1P = 0.05f;//いわゆる初弾精度
    public static float ReticletoUp1P = 0.02f;//レティクルの暴れる速度
    public static float ReticletoZero1P = 0.0025f;//レティクルが元に戻る速度
    public static int GunLevel1P = 1;//1-4;

    public static int Category2P = 0;
    public static float Speed2P = 10.0f;
    public static float Shotrate2P = 0.1f;
    public static float LastShot2P = 0;
    public static float RestBullet2P = 30;
    public static float FullBullet2P = 30;
    public static int Pellet2P = 1;
    public static bool AutoShot2P = true;
    public static float ReloadTime2P = 2.5f;
    public static float ReticleNoise2P = 0;//レティクルの暴れっぷり
    public static float ReticleNMin2P = 0.001f;//いわゆる初弾精度
    public static float ReticleNMax2P = 0.05f;//いわゆる初弾精度
    public static float ReticletoUp2P = 0.02f;//レティクルの暴れる速度
    public static float ReticletoZero2P = 0.0025f;//レティクルが元に戻る速度
    public static int GunLevel2P = 1;//1-4;


}
