using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTextSlideIn : MonoBehaviour {

    public GameObject Target;
    public AudioSource audioSource;
    private bool AudioPlay = false;
    private float TimeWatch;
    public static bool TitleButtonMoving = false;
    private float EASING = 0.05f;

    // Use this for initialization
    void Start()
    {
        if (EndFadeOut.Winner == 1) GetComponent<Text>().text = "PL1 Win!!";
        else GetComponent<Text>().text = "PL2 Win!!";
    }

    // Update is called once per frame
    void Update()
    {
        TimeWatch += Time.deltaTime;
        if (TimeWatch > 2f)
        {
            if(!AudioPlay)
            {
                audioSource.Play();
                AudioPlay = true;
            }
            Vector3 diff = Target.transform.position - transform.position;
            Vector3 v = diff * EASING;
            transform.position += v;

            // 十分近づいたらアニメーション終了
            if (diff.magnitude < 0.01f)
            {
               

            }


        }
    }
}
