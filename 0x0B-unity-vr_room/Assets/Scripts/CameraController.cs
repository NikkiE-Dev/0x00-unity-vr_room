using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject camera;
    // public float speed = 3;
    float rotationX = 0.0f;
    float rotationY = 0.0f;
    public float sensitivity = 15.0f;

    // Update is called once per frame
    void Update () {

        rotationY += Input.GetAxis("Mouse X") * sensitivity;
        rotationX += Input.GetAxis("Mouse Y") * sensitivity;
        transform.eulerAngles = new Vector3(-rotationX, rotationY, 0);

        if(Input.GetMouseButton(2))
        {
            camera.transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y, camera.transform.position.z + Input.GetAxis("Mouse ScrollWheel") * 10);
        }

    }
}
