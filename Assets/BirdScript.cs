using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float movementSpeed ;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("LogicScript").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.upArrowKey.wasPressedThisFrame || !birdIsAlive)
        {
            myRigidbody.linearVelocityY = movementSpeed;
        }

        else if (Keyboard.current.downArrowKey.wasPressedThisFrame || !birdIsAlive)
        {
            myRigidbody.linearVelocityY = -movementSpeed;
        }

        else if (Keyboard.current.leftArrowKey.wasPressedThisFrame || !birdIsAlive)
        {
            myRigidbody.linearVelocityX = -movementSpeed;
        }

        else if (Keyboard.current.rightArrowKey.wasPressedThisFrame || !birdIsAlive)
        {
            myRigidbody.linearVelocityX = movementSpeed;
        }


        else if (Keyboard.current.spaceKey.wasPressedThisFrame || !birdIsAlive)
        {
            myRigidbody.linearVelocity = Vector2.zero;
        }
        else if (Keyboard.current.rKey.wasPressedThisFrame || !birdIsAlive)
        {
            logic.restartGame();
            birdIsAlive = true;
            myRigidbody.linearVelocity = Vector2.zero;
        }
        





    }

    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;

    }
}
