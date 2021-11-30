using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    private Vector2 _direction;
    public float speed = 2f;
    protected Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            _direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            _direction = Vector2.down;
        }
        else
        {
            _direction = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        this.transform.Translate(_direction * Time.deltaTime * speed);
    }
}
