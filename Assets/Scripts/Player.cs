using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 0.01f;
    public float jumpForse = 200f;
    bool MoveUp;
    bool MoveDown;
    bool MoveLeft;
    bool MoveRight;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Движение вперед
        if(Input.GetKeyDown(KeyCode.W))
        MoveUp = true;
        if(Input.GetKeyUp(KeyCode.W))
        MoveUp = false;
        if (MoveUp)
        {
        transform.Translate(0,0,speed * 2);
        }
        // Движение назад
        if(Input.GetKeyDown(KeyCode.S))
        MoveDown = true;
        if(Input.GetKeyUp(KeyCode.S))
        MoveDown = false;
        if (MoveDown)
        {
        transform.Translate(0,0,-speed);
        }
        // Движение вправа
        if(Input.GetKeyDown(KeyCode.D))
        MoveRight = true;
        if(Input.GetKeyUp(KeyCode.D))
        MoveRight = false;
        if (MoveRight)
        {
        transform.Translate(speed,0,0);
        }
        // Движение влево
        if(Input.GetKeyDown(KeyCode.A))
        MoveLeft = true;
        if(Input.GetKeyUp(KeyCode.A))
        MoveLeft = false;
        if (MoveLeft)
        {
        transform.Translate(-speed,0,0);
        }
        // Прыжок
        if(Input.GetKeyDown(KeyCode.Space))
        {
        rb.AddForce(0,jumpForse,0);
        }
    }
}
