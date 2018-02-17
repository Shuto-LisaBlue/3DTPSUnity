using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndFadeOut : MonoBehaviour
{

    public GameObject PC1;
    public GameObject PC2;
    PlayerLife _playerLifePC1;
    PlayerLife _playerLifePC2;
    private float alpha = 1f;
    public static int Winner = 1;

    void Start()
    {
        _playerLifePC1 = PC1.GetComponent<PlayerLife>();
        _playerLifePC2 = PC2.GetComponent<PlayerLife>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Image>().color = new Color(0f, 0f, 0f, alpha);
        if (_playerLifePC1.KnockOut || _playerLifePC2.KnockOut)
        {
            alpha += 0.01f;
            if (alpha >= 1.1)
            {
                SceneManager.LoadScene("Result");
            }
        }
        else
        {
            alpha -= 0.01f;
            if (alpha < 0) alpha = 0;
        }
        if (_playerLifePC1.KnockOut == true) Winner = 2;
        else if (_playerLifePC2.KnockOut == true) Winner = 1;


    }
}
