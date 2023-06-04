using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mushroomstxt : MonoBehaviour
{
    private static int Mushroomsint;
    Text text;
    void Start()
    {
       text = GetComponent<Text>(); 
    }

    void Update()
    {
        text.text = Mushroomsint.ToString();    
    }
}
