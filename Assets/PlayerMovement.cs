using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController charController;
    public float speed = 6.0f;
    public Transform camera;
    public Light flashLight;

    void Start()
    {
        charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion characterRotation = camera.transform.rotation;
        characterRotation.x = 0;
        characterRotation.z = 0;

        transform.rotation = characterRotation;

        if (Input.GetKey(KeyCode.W))
            charController.Move(transform.TransformDirection(Vector3.forward) * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            charController.Move(transform.TransformDirection(Vector3.back) * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            charController.Move(transform.TransformDirection(Vector3.left) * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            charController.Move(transform.TransformDirection(Vector3.right) * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.F))
        {
            if (flashLight.enabled)
            {
                flashLight.enabled = false;
            } else
            {
                flashLight.enabled = true;
            }
        }
    }
}
