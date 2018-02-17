using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TitleSlideIn : MonoBehaviour
{

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
        if (JoyPadCheck.PadCheckPlayer1 && JoyPadCheck.PadCheckPlayer2)
        {

            Vector3 diff = Target.transform.position - transform.position;
            Vector3 v = diff * EASING;
            transform.position += v;

            // 十分近づいたらアニメーション終了
            if (diff.magnitude < 0.01f)
            {
                SceneManager.LoadScene("Setting");

            }


        }
    }
}
