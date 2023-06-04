using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Woodtxt : MonoBehaviour
{
    private static int Woodint;
    Text text;
    void Start()
    {
       text = GetComponent<Text>(); 
    }

    void Update()
    {
        text.text = Woodint.ToString();    
    }
}
