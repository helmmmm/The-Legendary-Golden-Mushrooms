using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraControl : MonoBehaviour
{
    // Camera on player, player's head
    public Camera playerCam;
    public float sensitivity;

    // The delta values of the mouse each frame
    public float deltaX;
    public float deltaY;

    // Player's rotation around the X and Y axis
    public float xRotation;
    public float yRotation;

    // Start is called before the first frame update
    void Start()
    {
        playerCam = Camera.main;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        yRotation += deltaX;
        xRotation -= deltaY;

        playerCam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        transform.rotation = Quaternion.Euler(0, yRotation, 0);

        if (Input.GetKey("escape"))
        {
            if (Cursor.visible)
            {
                Cursor.visible = false;
            }
            Cursor.visible = true;
        }
    }

    public void OnCameraPan(InputValue value)
    {
        // Get mouse delta as Vector2
        Vector2 inputVector = value.Get<Vector2>();
        deltaX = inputVector.x * sensitivity;
        deltaY = inputVector.y * sensitivity;
    }
}
