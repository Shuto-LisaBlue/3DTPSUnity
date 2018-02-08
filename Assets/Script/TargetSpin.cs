using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpin : MonoBehaviour {
    Transform _transform;

	// Use this for initialization
	void Start () {
        _transform = GetComponent<Transform>();

	}
	
	// Update is called once per frame
	void Update () {
        _transform.Rotate(new Vector3(0f, 1.0f, 0f));
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(this.gameObject);
        }
    }
}
