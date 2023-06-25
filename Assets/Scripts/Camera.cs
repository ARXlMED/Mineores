using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float mouseSens = 200f;
	public Transform playerBody;
	float xRotation = 0f;
    float yRotation = 60f;

	void Update ()
    {
		float mouseX = Input.GetAxis ("Mouse X") * mouseSens * Time.deltaTime;
		float mouseY = Input.GetAxis ("Mouse Y") * mouseSens * Time.deltaTime;

        // По движение камеры

		xRotation -= mouseY;
        yRotation -= mouseX;
		xRotation = Mathf.Clamp (xRotation, -80f, 75f);
        transform.localRotation = Quaternion.Euler (xRotation, -yRotation, 0f);

        // Движение перса вместе с камерой

		playerBody.Rotate (Vector3.up * mouseX);
	}
}

