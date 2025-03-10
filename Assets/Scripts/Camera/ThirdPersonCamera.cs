using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform Target;
    public float MouseSensitivity = 10f;
    public Vector3 offset = new Vector3(0, 2, -5);

    private float verticalRotation;
    private float horizontalRotation;

    void LateUpdate()
    {
        if (Target == null)
        {
            return;
        }

        float mouseX = Input.GetAxis("Mouse X") * MouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * MouseSensitivity;

        horizontalRotation += mouseX;
        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -20f, 70f);

        Quaternion rotation = Quaternion.Euler(verticalRotation, horizontalRotation, 0);
        Vector3 targetPosition = Target.position + rotation * offset;

        transform.position = targetPosition;
        transform.LookAt(Target.position + Vector3.up * 1.5f);
    }
}
