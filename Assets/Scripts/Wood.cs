using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{
    void OnTriggerEnter(Collider collision) 
    {  
        if (collision.CompareTag("Player"))
        {
            Player.Woodint += 1;
            Destroy(gameObject);
        }
    }
}
