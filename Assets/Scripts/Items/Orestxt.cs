using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Orestxt : MonoBehaviour
{
    private static int Oresint;
    Text text;
    void Start()
    {
       text = GetComponent<Text>(); 
    }

    void Update()
    {
        text.text = Oresint.ToString();    
    }
}
