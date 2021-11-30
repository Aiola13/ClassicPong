using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounceStrength = 1;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            Vector2 normal = other.GetContact(0).normal;
            other.gameObject.GetComponent<Rigidbody2D>().AddForce(-normal * this.bounceStrength);
        }
    }
}
