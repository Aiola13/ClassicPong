using System;
using UnityEngine;

    public class ComputerPaddle : MonoBehaviour
    {
        private Vector2 _direction;
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                _direction = Vector2.up;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                _direction = Vector2.down;
            }
            else
            {
                _direction = Vector2.zero;
            }
        }
    }
