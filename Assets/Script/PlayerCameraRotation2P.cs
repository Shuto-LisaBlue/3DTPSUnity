using UnityEngine;

public class PlayerCameraRotation2P : MonoBehaviour
{
    float inputHorizontal;
    float inputVertical;
    Rigidbody rb;
    Animator animator;
    GameObject camera2p;
    public GameObject MiniColider;
    MiniColliderCheck miniCo;

    public float moveSpeed = 3f;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        camera2p = GameObject.FindWithTag("SubCamera");
        miniCo = MiniColider.GetComponent<MiniColliderCheck>();
    }

    void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal2P");
        animator.SetFloat("Direction", inputHorizontal);
        inputVertical = Input.GetAxisRaw("Vertical2P");
        animator.SetFloat("Speed", inputVertical);
        var jump = Input.GetAxis("Jump2P");

        if (jump != 0 && miniCo.TouchGround == true)
        {
            rb.AddForce(Vector3.up * 3f, ForceMode.Impulse);
            miniCo.TouchGround = false;
        }
    }


    void FixedUpdate()
    {
        // カメラの方向から、X-Z平面の単位ベクトルを取得
        //Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;
        Vector3 cameraForward = Vector3.Scale(camera2p.transform.forward, new Vector3(1, 0, 1)).normalized;

        // 方向キーの入力値とカメラの向きから、移動方向を決定
        //Vector3 moveForward = cameraForward * inputVertical + Camera.main.transform.right * inputHorizontal;
        Vector3 moveForward = cameraForward * inputVertical + camera2p.transform.right * inputHorizontal;

        // 移動方向にスピードを掛ける。ジャンプや落下がある場合は、別途Y軸方向の速度ベクトルを足す。
        rb.velocity = moveForward * moveSpeed + new Vector3(0, rb.velocity.y, 0);

        transform.rotation = Quaternion.LookRotation(cameraForward);

    }
}
