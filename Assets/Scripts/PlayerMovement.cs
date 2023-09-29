using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    
   [SerializeField] private float strafeSpeed;
    [SerializeField] private float jumpForce;

    protected bool strafeLeft = false;
    protected bool strafeRight = false;
    protected bool doJump = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            strafeRight = true;
            Debug.Log("Нажали направо");
        }
        else
        {
            strafeLeft = false;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            strafeLeft = true;
            Debug.Log("Нажали налево");
        }
        else
        {
            strafeRight = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            doJump = true;
            Debug.Log("Нажали пробел");
        }
        else
        {
            doJump = false;
        }
    }

    private void FixedUpdate()
    {
        if (strafeLeft)
        {
            _rigidbody2D.AddForce(Vector2.left * strafeSpeed, ForceMode2D.Impulse);
            Debug.Log("Двигаюсь налево");
        }

        if (strafeRight)
        {
            _rigidbody2D.AddForce(Vector2.right * strafeSpeed, ForceMode2D.Impulse);
            Debug.Log("Двигаюсь направо");
        }

        if (doJump)
        {
            _rigidbody2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            Debug.Log("Прыгаю");
        }
    }
}
