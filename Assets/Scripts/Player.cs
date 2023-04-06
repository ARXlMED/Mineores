using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 0.01f;
    public float jumpForse = 200f;
    public Animator animator;
    public bool IsGround;
    public bool MoveUp;
    public bool MoveDown;
    public bool MoveLeft;
    public bool MoveRight;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Ground"))
        {
            IsGround = true;
        }
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
            animator.SetBool("Walking", true);
        }
        if (MoveUp = false)
        {
            animator.SetBool("Walking", false);
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
        // Движение вправо
        if(Input.GetKeyDown(KeyCode.D))
            MoveRight = true;
        if(Input.GetKeyUp(KeyCode.D))
            MoveRight = false;
        if (MoveRight)
        {
            transform.Translate(speed,0,0);
            animator.SetBool("Right", true);
        }
        if (MoveRight = false)
        {
            animator.SetBool("Right", false);
        }
        // Движение влево
        if(Input.GetKeyDown(KeyCode.A))
            MoveLeft = true;
        if(Input.GetKeyUp(KeyCode.A))
            MoveLeft = false;
        if (MoveLeft)
        {
            transform.Translate(-speed,0,0);
            animator.SetBool("Left", true);
        }
        if (MoveLeft = false)
        {
            animator.SetBool("Left", false);
        }
        // Прыжок
        if(Input.GetKeyDown(KeyCode.Space) && IsGround)
        {
            rb.AddForce(0,jumpForse,0);
            animator.SetBool("Jumping", true);
        }
        if(IsGround = true)
        {
            animator.SetBool("Jumping", false);
        }
    }
}
