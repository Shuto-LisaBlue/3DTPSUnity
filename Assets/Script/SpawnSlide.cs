using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSlide : MonoBehaviour {

    public GameObject Target;
    public static bool TitleButtonMoving = false;
    private float EASING = 0.05f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 diff = Target.transform.position - transform.position;
        Vector3 v = diff * EASING;
        transform.position += v;

        // 十分近づいたらアニメーション終了
        if (diff.magnitude < 0.01f)
        {
            Destroy(this);

        }

    }
}
