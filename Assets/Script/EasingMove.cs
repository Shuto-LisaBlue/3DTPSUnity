using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EasingMove : MonoBehaviour
{
    public GameObject target;
    public bool Moving = true;
    public bool mode2P = false;
    private float Easing = 0.05f;

    void Start()
    {
        if (!mode2P && EndFadeOut.Winner == 1) Moving = false;
        else if (mode2P && EndFadeOut.Winner == 2) Moving = false;
    }

    void Update()
    {
        if (Moving == false)
        {
            Vector3 diff = target.transform.position - transform.position;
            Vector3 v = diff * Easing;
            transform.position += v;

            if (diff.magnitude < 0.01f)
            {
                Moving = true;
            }
        }
    }
}
