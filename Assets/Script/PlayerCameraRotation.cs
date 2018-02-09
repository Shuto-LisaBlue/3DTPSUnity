using UnityEngine;

public class PlayerCameraRotation : MonoBehaviour
{
    float inputHorizontal;
    float inputVertical;
    Rigidbody rb;
    Animator animator;
    bool TouchGround = true;

    public float moveSpeed = 3f;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Direction", inputHorizontal * -1);
        inputVertical = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Speed", Mathf.Abs(inputVertical));
        var jump = Input.GetAxis("Jump");

        if (jump != 0 && TouchGround == true)
        {
            rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
            TouchGround = false;
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Target")
        {
            TouchGround = true;
        }
        else TouchGround = false;
    }
    void FixedUpdate()
    {
        // カメラの方向から、X-Z平面の単位ベクトルを取得
        Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;

        // 方向キーの入力値とカメラの向きから、移動方向を決定
        Vector3 moveForward = cameraForward * inputVertical + Camera.main.transform.right * inputHorizontal;

        // 移動方向にスピードを掛ける。ジャンプや落下がある場合は、別途Y軸方向の速度ベクトルを足す。
        rb.velocity = moveForward * moveSpeed + new Vector3(0, rb.velocity.y, 0);

        // キャラクターの向きを進行方向に
        if (moveForward != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveForward);
        }
    }
}
