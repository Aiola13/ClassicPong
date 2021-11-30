using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    public float speed = 100f;
    private float _x;
    private float _y;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {  
        ResetPosition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Launch()
    {
        if (Random.value < 0.5f)
        {
            _y = Random.Range(-1.0f, -0.5f);
            _x = -1.0f; 
        }
        else
        {
            _x = 1.0f;
            _y = Random.Range(0.5f, 1.0f);
        }
        
        _rigidbody.AddForce(new Vector2(_x, _y) * this.speed);
    }

    public void ResetPosition()
    {
        _rigidbody.position = Vector2.zero;
        _rigidbody.velocity = Vector2.zero;
        
        Launch();
    }
    
}
