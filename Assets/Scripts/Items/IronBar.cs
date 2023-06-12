using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IronBar : MonoBehaviour
{
    public static int Iron;
    Text text;
    void Start()
    {
       text = GetComponent<Text>(); 
    }

    void Update()
    {
        text.text = Iron.ToString();    
    }
}
