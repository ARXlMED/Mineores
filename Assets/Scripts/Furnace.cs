using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furnace : MonoBehaviour
{
    bool furbool = false;
    public GameObject furnancemenu;
    void Start()
    {
        furnancemenu = GameObject.Find("Furcace");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            furbool = true;
            furnancemenu.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            furbool = false;
            furnancemenu.SetActive(false);
        }
    }
}
