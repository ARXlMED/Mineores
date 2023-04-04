using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject inventor;
    public bool invbool;
    void Start() 
    {
        invbool = false;
        inventor.SetActive(false);
    }
    void Update() 
    {
       if(Input.GetKeyDown(KeyCode.I) && invbool == false)
       {
        inventor.SetActive(true);
        invbool = true;    
       }
       if(Input.GetKeyDown(KeyCode.I) && invbool == true)
       {
        inventor.SetActive(false);
        invbool = false;    
       }  
    }
    public void ExitInv()
    {
        inventor.SetActive(false);
    }

}