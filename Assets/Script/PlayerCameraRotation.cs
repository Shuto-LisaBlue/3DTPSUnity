﻿using UnityEngine;

public class PlayerCameraRotation : MonoBehaviour
{
    float inputHorizontal;
    float inputVertical;
    Rigidbody rb;
    Animator animator;
    public GameObject MiniColider;
    MiniColliderCheck miniCo;

    public float moveSpeed = 3f;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        miniCo = MiniColider.GetComponent<MiniColliderCheck>();
    }

    void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Direction", inputHorizontal);
        inputVertical = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Speed", inputVertical);
        var jump = Input.GetAxis("Jump");

        if (jump != 0 && miniCo.TouchGround == true)
        {
            rb.AddForce(Vector3.up * 3f, ForceMode.Impulse);
            miniCo.TouchGround = false;
        }
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

        transform.rotation = Quaternion.LookRotation(cameraForward);

        //if (moveForward != Vector3.zero)
        //{
        //    transform.rotation = Quaternion.LookRotation(moveForward);
        //}
    }
}
