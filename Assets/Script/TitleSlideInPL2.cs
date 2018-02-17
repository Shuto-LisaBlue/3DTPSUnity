using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSlideInPL2 : MonoBehaviour {

    public GameObject Target;
    public GameObject CatchButton;
    SettingChanger settingChanger;
    public static bool TitleButtonMoving = false;
    private float EASING = 0.05f;

    // Use this for initialization
    void Start()
    {
        settingChanger = CatchButton.GetComponent<SettingChanger>();

    }

    // Update is called once per frame
    void Update()
    {
        if (settingChanger.NextScene)
        {

            Vector3 diff = Target.transform.position - transform.position;
            Vector3 v = diff * EASING;
            transform.position += v;

            // 十分近づいたらアニメーション終了
            if (diff.magnitude < 0.01f)
            {
                SceneManager.LoadScene("Move");

            }


        }
    }
}
