using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using System.Collections;

public class RestTargetSearch : MonoBehaviour
{
    GameObject[] tagObjects;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Check("Target");
    }
    void Check(string tagname)
    {
        tagObjects = GameObject.FindGameObjectsWithTag(tagname);
        GetComponent<Text>().text = (tagObjects.Length).ToString();
    }
}
