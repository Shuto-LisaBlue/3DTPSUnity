using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReloadBarSetting : MonoBehaviour
{
    public bool mode2P;
    public bool modeFillBar;
    public GameObject Player;
    ShotBullet shotBullet;
    ShotBullet2P shotBullet2P;



    // Use this for initialization
    void Start()
    {
        if (!mode2P)
        {
            shotBullet = Player.GetComponent<ShotBullet>();
        }
        else
        {
            shotBullet2P = Player.GetComponent<ShotBullet2P>();
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (!mode2P)
        {
            if (!modeFillBar)
            {
                if (shotBullet.RestBullet == 0)
                {
                    this.GetComponent<Image>().color = new Color(1, 1, 1, 1);
                }
                else
                {
                    this.GetComponent<Image>().color = new Color(1, 1, 1, 0);
                }
            }
            else
            {
                float Filled = (shotBullet.LastShot / shotBullet.ReloadTime);
                if (shotBullet.RestBullet == 0)
                {
                    this.GetComponent<Image>().color = new Color(1, 0, 0, 1);
                    this.GetComponent<Image>().rectTransform.localScale = new Vector3(Filled, 1f, 1f);
                }
                else
                {
                    this.GetComponent<Image>().color = new Color(1, 0, 0, 0);
                }
            }
        }
        else
        {
            if (!modeFillBar)
            {
                if (shotBullet2P.RestBullet == 0)
                {
                    this.GetComponent<Image>().color = new Color(1, 1, 1, 1);
                }
                else
                {
                    this.GetComponent<Image>().color = new Color(1, 1, 1, 0);
                }
            }
            else
            {
                float Filled = (shotBullet2P.LastShot / shotBullet2P.ReloadTime);
                if (shotBullet2P.RestBullet == 0)
                {
                    this.GetComponent<Image>().color = new Color(1, 0, 0, 1);
                    this.GetComponent<Image>().rectTransform.localScale = new Vector3(Filled, 1f, 1f);
                }
                else
                {
                    this.GetComponent<Image>().color = new Color(1, 0, 0, 0);
                }
            }

        }
    }
}
