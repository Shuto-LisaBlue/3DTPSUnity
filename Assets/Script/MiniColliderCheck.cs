using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniColliderCheck : MonoBehaviour
{

    public bool TouchGround;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Ground")
        {
            TouchGround = true;
        }
    }
}
