using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ores : MonoBehaviour
{
    void OnTriggerEnter(Collider collision) 
    {  
        if (collision.CompareTag("Player"))
        {
            Orestxt.Oresint += 1;
            Destroy(gameObject);
        }
    }
}
