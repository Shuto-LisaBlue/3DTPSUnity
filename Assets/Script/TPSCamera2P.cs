using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class TPSCamera2P : MonoBehaviour
{
    private GameObject _object;
    public Transform trfCamera;
    public Vector3 Offset = new Vector3(0, 0, 0);
    public float RotSpeed = 10.0f;
    private Transform myTrf;
    private float AngX = 0, AngY = 0;
    private float nAngX = 0, nAngY = 0;
    private float MousePosX, MousePosY, Radius = 3.0f, subRadius;
    private Vector3 CameraPos, initCameraPos, Center;

    // Use this for initialization
    void Start()
    {
        _object = GameObject.Find("Goal");
        this.transform.position = _object.transform.position + Vector3.up;
        initCameraPos = new Vector3(0, 0, -Radius);
        myTrf = transform;
        trfCamera.position = myTrf.position + Offset + initCameraPos;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Center = myTrf.position + Offset;

        if (Input.GetKeyUp(KeyCode.Q))
        {
            //MousePosX = Input.mousePosition.x;
            //MousePosY = Input.mousePosition.y;

            MousePosX = Input.GetAxisRaw("2PJoyX");
            MousePosY = Input.GetAxisRaw("2PJoyY");
            nAngX = AngX;
            nAngY = AngY;
        }
        if (!Input.GetKey(KeyCode.Q))
        {
            //AngY = nAngY - (MousePosX - Input.mousePosition.x) / 5.0f;
            //AngX = nAngX + (MousePosY - Input.mousePosition.y) / 5.0f;

            AngX = AngX + (Input.GetAxisRaw("2PJoyY") * 2f);
            AngY = AngY + (Input.GetAxisRaw("2PJoyX") * 2f);
        }

        AngX = Mathf.Clamp(AngX, -79.999f, 79.999f);

        float dist = Vector3.Distance(trfCamera.position, Center);
        RaycastHit RayHit;
        if (Physics.Raycast(Center, CameraPos, out RayHit, dist, 1 << 8))
        {
            subRadius = RayHit.distance + 0.5f;
            initCameraPos = new Vector3(0, 0, -subRadius);
            if (Radius <= subRadius)
            {
                initCameraPos = new Vector3(0, 0, -Radius);
            }
        }
        else
        {
            if (Radius >= subRadius)
            {
                subRadius = subRadius + 20.0f * Time.deltaTime;
                initCameraPos = new Vector3(0, 0, -subRadius);
            }
            else
            {
                initCameraPos = new Vector3(0, 0, -Radius);
            }
        }

        CameraPos = Quaternion.AngleAxis(AngY, Vector3.up) *
                Quaternion.AngleAxis(AngX, Vector3.right) * initCameraPos;
        trfCamera.position = Center + CameraPos;
        trfCamera.LookAt(Center);
    }
}
