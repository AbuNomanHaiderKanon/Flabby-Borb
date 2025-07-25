using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem.Processors;

public class VerticalMovement : MonoBehaviour
{
    public float movementSpeed = 5;
    public float deadzone = -30;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * movementSpeed * Time.deltaTime;

        if (transform.position.y < deadzone)
        {
            Destroy(gameObject);
        }
    }
}
