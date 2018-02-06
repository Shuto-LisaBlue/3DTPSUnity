﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPSCamera : MonoBehaviour
{

    public Transform trfCamera;
    public Vector3 Offset = new Vector3(0, 0, 0);
    public float RotSpeed = 10.0f;
    private Transform myTrf;
    private float AngX = 0, AngY = 0;
    private float nAngX, nAngY;
    private float MousePosX, MousePosY, Radius = 3.0f, subRadius;
    private Vector3 CameraPos, initCameraPos, Center;

    // Use this for initialization
    void Start()
    {
        initCameraPos = new Vector3(0, 0, -Radius);
        myTrf = transform;
        trfCamera.position = myTrf.position + Offset + initCameraPos;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Center = myTrf.position + Offset;
        if (Input.GetMouseButtonDown(1))
        {
            MousePosX = Input.mousePosition.x;
            MousePosY = Input.mousePosition.y;
            nAngX = AngX;
            nAngY = AngY;
        }
        if (Input.GetMouseButton(1))
        {
            AngY = nAngY - (MousePosX - Input.mousePosition.x) / 5.0f;
            AngX = nAngX + (MousePosY - Input.mousePosition.y) / 5.0f;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            AngY = AngY - 10.0f * Time.deltaTime * RotSpeed;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            AngY = AngY + 10.0f * Time.deltaTime * RotSpeed;
        }
        AngX = Mathf.Clamp(AngX, 0.0f, 89.999f);

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

        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            Radius = Radius + Input.GetAxis("Mouse ScrollWheel") *
                Time.deltaTime * 500;
            Radius = Mathf.Clamp(Radius, 1.0f, 30.0f);
        }

        CameraPos = Quaternion.AngleAxis(AngY, Vector3.up) *
                Quaternion.AngleAxis(AngX - 20, Vector3.right) * initCameraPos;
        trfCamera.position = Center + CameraPos;
        trfCamera.LookAt(Center);
    }
}