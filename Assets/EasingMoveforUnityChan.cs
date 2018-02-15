using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasingMoveforUnityChan : MonoBehaviour
{

    public GameObject target;
    public bool Moving = true;
    public bool mode2P = false;
    private float Easing = 0.05f;
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
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
        else
        {
            if (!mode2P && EndFadeOut.Winner == 1) animator.SetBool("Winner", true);
            else if (mode2P && EndFadeOut.Winner == 2) animator.SetBool("Winner", true);
        }
    }
}
