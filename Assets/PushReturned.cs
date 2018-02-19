using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushReturned : MonoBehaviour {
    public GameObject Target;    
    private float EASING = 0.05f;
    public bool Moving=false;
    void Update()
    {
        if(Moving == true)
        {
            Vector3 diff = Target.transform.position - transform.position;
            Vector3 v = diff * EASING;
            transform.position += v;

            // 十分近づいたらアニメーション終了
            if (diff.magnitude < 0.01f)
            {
                Moving = false;
            }


        }

    }
    
    public void OnClick()
    {
        Moving = true;
        EasingMoveforTitle3.TitleButtonMoving = false;
    }

}
