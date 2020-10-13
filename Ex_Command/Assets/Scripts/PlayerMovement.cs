using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    private ICommand moveLeft, moveRight, moveUp, moveDown;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            moveLeft = new MoveLeft(transform, speed);
            moveLeft.Execute();
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveRight = new MoveRight(transform, speed);
            moveRight.Execute();
        }
        if (Input.GetKey(KeyCode.W))
        {
            moveUp = new MoveUp(transform, speed);
            moveUp.Execute();
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDown = new MoveDown(transform, speed);
            moveDown.Execute();
        }
    }
}
