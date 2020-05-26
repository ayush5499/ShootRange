using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class FreeCam : MonoBehaviour
{
    public float freeLookSensitivity = 3f;

    void Update()
    {
        float newRotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * freeLookSensitivity;
        float newRotationY = transform.localEulerAngles.x - Input.GetAxis("Mouse Y") * freeLookSensitivity;
        transform.localEulerAngles = new Vector3(newRotationY, newRotationX, 0f);

        if (Input.GetKeyDown(KeyCode.Mouse2))
        {
            Aim();
        }
        else if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Shoot();
        }
    }

    public void Aim()
    {
        Cursor.visible = true;
    }

    public void Shoot()
    {
        Cursor.visible = false;
    }
}