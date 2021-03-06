﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EasingMoveforTitle : MonoBehaviour
{
    public GameObject Button;
    public GameObject Target;
    PushReturned _push;
    public static bool TitleButtonMoving = false;
    private float EASING = 0.05f;
    public bool TutorialCheck = false;
    void Start()
    {
        _push = Button.GetComponent<PushReturned>();
    }
    void Update()
    {
        if (TitleButtonMoving == true)
        {
            Vector3 diff = Target.transform.position - transform.position;
            Vector3 v = diff * EASING;
            transform.position += v;

            // 十分近づいたらアニメーション終了
            if (diff.magnitude < 0.01f)
            {
                TitleButtonMoving = false;
            }
        }
    }
    public void OnClick()
    {
        if(TutorialCheck)
        {
            EasingMoveforTitle3.TitleButtonMoving = true;
            _push.Moving = false;
        }
        else
        {
        EasingMoveforTitle2.TitleButtonMoving = true;
        JoyPadCheck.PadCheckMode = true;

        }
    }
}
