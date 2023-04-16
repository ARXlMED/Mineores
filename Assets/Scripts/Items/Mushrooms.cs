using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushrooms : MonoBehaviour
{
    void OnTriggerEnter(Collider collision) 
    {  
        if (collision.CompareTag("Player"))
        {
            Mushroomstxt.Mushroomsint += 1;
            Destroy(gameObject);
        }
    }
}
