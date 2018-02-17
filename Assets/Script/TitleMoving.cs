using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleMoving : MonoBehaviour
{

    public GameObject FirstFade;
    public GameObject SecondFade;
    public GameObject _Logo;
    public GameObject _Text;
    public AudioSource audioSource;
    private float TimeWatch = 0;
    private bool MusicPlay = false;

    void Start()
    {

    }

    void Update()
    {
        TimeWatch += Time.deltaTime;

        if (TimeWatch > 2f && !MusicPlay)
        {
            audioSource.Play();
            MusicPlay = true;
        }
        if (TimeWatch > 3f && !EasingMoveforTitle.TitleButtonMoving)
        {
            Destroy(FirstFade);
            Destroy(SecondFade);
            Destroy(_Logo);
            Destroy(_Text);
            EasingMoveforTitle.TitleButtonMoving = true;
        }
        else if(TimeWatch < 3f)
        {
            FirstFade.GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f - TimeWatch);
            SecondFade.GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f - (TimeWatch - 2f));
            _Logo.GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f - (TimeWatch - 2f));
            _Text.GetComponent<Text>().color = new Color(0f, 0f, 0f, 1f - (TimeWatch - 2f));
        }
    }
}
