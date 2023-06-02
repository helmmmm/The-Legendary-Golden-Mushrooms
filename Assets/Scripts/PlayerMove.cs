using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public Vector3 direction;
    public float speed;
    public int itemsCollected;

    public Rigidbody rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    
    void FixedUpdate()
    {
        Vector3 localDirection = transform.TransformDirection(direction);
        rb.MovePosition(rb.position + (localDirection * speed  * Time.deltaTime));
    }

    public void OnPlayerMove(InputValue value)
    {
        Vector2 inputVector = value.Get<Vector2>();
        direction = new Vector3(inputVector.x, 0, inputVector.y);

        direction.x = inputVector.x;
        direction.z = inputVector.y;

        direction.y = 0f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lava"))
        {
            SceneManager.LoadScene("ForestScene");
        }
        else if (other.CompareTag("Collectibles"))
        {
            itemsCollected++;
            Destroy(other.gameObject);
            Debug.Log(itemsCollected);
        }
    }
}
