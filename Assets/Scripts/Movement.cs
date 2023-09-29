using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            //transform.Translate(_speed * Time.deltaTime, 0, 0);
            //transform.Translate(Vector3.right * _speed);
            transform.Translate(Vector3.right * _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            //transform.Translate(_speed * Time.deltaTime * -1, 0, 0);
            //transform.Translate(Vector3.left * _speed);
            transform.Translate(Vector3.left * _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            //transform.Translate(0, _speed * Time.deltaTime * 3, 0);
            //transform.Translate(Vector3.up * _speed);
            transform.Translate(Vector3.up * _jumpForce * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            //transform.Translate(0, _speed * Time.deltaTime * -1, 0);
            //transform.Translate(Vector3.down * _speed);
            transform.Translate(Vector3.down * _speed * Time.deltaTime);
        }
    }
}