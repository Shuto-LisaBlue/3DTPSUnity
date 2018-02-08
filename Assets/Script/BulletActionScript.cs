using UnityEngine;

public class BulletActionScript : MonoBehaviour {
    private float Times = 0;
    public bool CollisionDelete = true;
	void Start () {
		
	}
	
	void Update () {
		Times += Time.deltaTime;
        if (Times >= 3.0f)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (CollisionDelete == true)
        {
            if (other.gameObject.tag == "Ground" || other.gameObject.tag == "Target")
            {
                Destroy(this.gameObject);
            }
        }
    }
}
