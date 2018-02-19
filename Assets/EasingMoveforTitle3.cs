using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasingMoveforTitle3 : MonoBehaviour {
    public GameObject Target;
    public static bool TitleButtonMoving = false;
    private float EASING = 0.05f;

    // Update is called once per frame
    void Update()
    {
        if (TitleButtonMoving == true)
        {
            Debug.Log("Moved");
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
}
