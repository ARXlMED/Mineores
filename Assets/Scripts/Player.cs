using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 0.01f;
    public float jumpForse = 200f;
    public Animator animator;
    public GameObject ground;
    public bool IsGround;
    public bool MoveUp;
    public bool MoveDown;
    public bool MoveLeft;
    public bool MoveRight;

    public GameObject furnace;
    public GameObject furnaceplace;

    //bool furbool = false;
    public GameObject furnancemenu;
    public Inventory a;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        IsGround = false;
    }
    //Проверка стоит ли на земле
    void OnCollisionEnter(Collision ground) 
    {
        IsGround = true;
    }
    //else Проверка стоит ли на земле
    void OnCollisionExit(Collision ground) 
    {
        IsGround = false;
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
        if (MoveUp == false)
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
        if (MoveRight == false)
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
        if (MoveLeft == false)
        {
            animator.SetBool("Left", false);
        }
        // Прыжок
        if(Input.GetKeyDown(KeyCode.Space) && IsGround)
        {
            rb.AddForce(0,jumpForse,0);
        }
        if(IsGround == true)
        {
            animator.SetBool("Jumping", false);
        }
        if (IsGround == false)
        {
            animator.SetBool("Jumping", true);
        }
        // Спаун печки
        if (Input.GetKeyDown(KeyCode.F) /*&& furnaceplace.transform.parent == null*/)
        {
            Instantiate(furnace, furnaceplace.transform.position, furnaceplace.transform.rotation);
        }
    }
    // Включение интерфейса при подходе к печке
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Furnace"))
        {
            //furbool = true;
            furnancemenu.SetActive(true);
            a.inventor.SetActive(true);
        }
    }
    // Выключение интерфейса при подходе к печке
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Furnace"))
        {
            //furbool = false;
            furnancemenu.SetActive(false);
            a.inventor.SetActive(false);
        }
    }



}
