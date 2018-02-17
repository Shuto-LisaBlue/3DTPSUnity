using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ResultSlideIn : MonoBehaviour
{

    public GameObject Target;
    public bool GotoTitle = false;
    public bool GotoBattle = false;
    private float EASING = 0.05f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GotoTitle || GotoBattle)
        {
            if (GotoTitle)
            {
                GetComponent<Image>().color = new Color(1f, 1f, 1f);
            }
            else
            {
                GetComponent<Image>().color = new Color(0f, 0f, 0f);
            }

            Vector3 diff = Target.transform.position - transform.position;
            Vector3 v = diff * EASING;
            transform.position += v;

            // 十分近づいたらアニメーション終了
            if (diff.magnitude < 0.01f)
            {

                if (GotoTitle)
                {
                    SceneManager.LoadScene("Title");

                }
                else
                {
                    SceneManager.LoadScene("Move");

                }

            }
        }
    }
}
