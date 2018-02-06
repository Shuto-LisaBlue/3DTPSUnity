using UnityEngine;

public class BulletActionScript : MonoBehaviour {
    private float Times = 0;
	void Start () {
		
	}
	
	void Update () {
		Times += Time.deltaTime;
        if (Times >= 1.0f)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Destroy(this.gameObject);
        }
    }
}
