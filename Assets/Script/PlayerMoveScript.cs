using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{
    public float speed = 10.0f;
    private Animator _animator;
    private Transform _transform;
    void Start()
    {
        _animator = GetComponent<Animator>();
        _transform = GetComponent<Transform>();

    }

    void Update()
    {
        var v = Input.GetAxis("Vertical");
        _animator.SetFloat("Speed", v);

        var h = Input.GetAxis("Horizontal");
        _animator.SetFloat("Direction", h);

        var jump = Input.GetAxis("Jump");
        _animator.SetBool("Jump", jump != 0);

        if (v > 0) _transform.Translate(0.0f, 0.0f, v / 10.0f);
        else _transform.Translate(0.0f, 0.0f, v / 30.0f);
        _transform.Rotate(new Vector3(0.0f, h * 2.0f, 0.0f));

    }
}

