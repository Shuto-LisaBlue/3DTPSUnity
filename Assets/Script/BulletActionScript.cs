using UnityEngine;

public class BulletActionScript : MonoBehaviour
{
    private float Times = 0;
    public float AliveTime = 3.0f;
    public bool CollisionStop = true;
    public bool GrenadeType = false;
    public bool CollisionBreak = false;
    public bool LisaShotGun = false;
    public bool LisaExtra = false;
    public float GrenadePellet = 1;
    public float SplashPower = 0f;
    private int ExtraSpawn = 1;
    public GameObject Bullet;
    void Start()
    {

    }

    void Update()
    {
        Times += Time.deltaTime;
        if (LisaExtra == true)
        {
            if (Times >= 1f)
            {
                for (int i = 0; i < ExtraSpawn*ExtraSpawn; i++)
                {
                    GameObject bullets = GameObject.Instantiate(Bullet, this.transform.position, Quaternion.identity) as GameObject;
                    bullets.transform.position = this.transform.position;
                    bullets.GetComponent<TrailRenderer>().enabled = true;
                    Vector3 force;
                    float NoiseX = Random.Range(-SplashPower, SplashPower);
                    float NoiseY = Random.Range(-SplashPower, SplashPower / 2);
                    float NoiseZ = Random.Range(-SplashPower, SplashPower);
                    force = (this.gameObject.transform.forward + new Vector3(NoiseX, NoiseY, NoiseZ)) * (ExtraSpawn*ExtraSpawn);
                    bullets.GetComponent<Rigidbody>().AddForce(force, ForceMode.Impulse);
                    Times = 0;
                }
                ExtraSpawn++;
                if (ExtraSpawn >= 11)
                {
                    Destroy(this.gameObject);
                }
            }
        }
        else if (Times >= AliveTime)
        {
            if (GrenadeType == true)
            {
                for (int i = 0; i < GrenadePellet; i++)
                {
                    GameObject bullets = GameObject.Instantiate(Bullet, this.transform.position, Quaternion.identity) as GameObject;
                    bullets.transform.position = this.transform.position;
                    bullets.GetComponent<TrailRenderer>().enabled = true;
                    Vector3 force;
                    float NoiseX = Random.Range(-SplashPower, SplashPower);
                    float NoiseY = Random.Range(-SplashPower, SplashPower / 2);
                    float NoiseZ = Random.Range(-SplashPower, SplashPower);
                    force = (this.gameObject.transform.forward + new Vector3(NoiseX, NoiseY, NoiseZ)) * 30;
                    bullets.GetComponent<Rigidbody>().AddForce(force, ForceMode.Impulse);
                }

            }
            else if (LisaShotGun == true)
            {
                for (int i = 0; i < 5; i++)
                {
                    GameObject bullets = GameObject.Instantiate(Bullet, this.transform.position, Quaternion.identity) as GameObject;
                    bullets.transform.position = this.transform.position;
                    bullets.GetComponent<TrailRenderer>().enabled = true;
                    Vector3 force;
                    float NoiseX = Random.Range(-SplashPower, SplashPower);
                    float NoiseY = Random.Range(-SplashPower, SplashPower / 2);
                    float NoiseZ = Random.Range(-SplashPower, SplashPower);
                    force = (this.gameObject.transform.forward + new Vector3(NoiseX, NoiseY, NoiseZ)) * 1;
                    bullets.GetComponent<Rigidbody>().AddForce(force, ForceMode.Impulse);
                }
            }

            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (CollisionStop == true)
        {
            if (other.gameObject.tag == "Ground" || other.gameObject.tag == "Target")
            {
                this.GetComponent<Rigidbody>().velocity = Vector3.zero;
                this.GetComponent<Rigidbody>().isKinematic = true;
            }
        }
        if (CollisionBreak == true)
        {
            Destroy(this.gameObject);
        }
    }
}
