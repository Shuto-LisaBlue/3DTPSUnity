using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerLifeDraw : MonoBehaviour
{
    public GameObject _object;
    private PlayerLife _Life;
    public bool Mode2P = false;
    void Start()
    {
        if (Mode2P == false)
        {
            _Life = _object.GetComponent<PlayerLife>();
        }
        else
        {
            _Life = _object.GetComponent<PlayerLife>();
        }
    }

    void Update()
    {
        if (Mode2P == false) GetComponent<Text>().text = ((int)_Life.Life).ToString();
        else GetComponent<Text>().text = ((int)_Life.Life).ToString();
    }
}
