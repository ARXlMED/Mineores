using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject inventor;
    private bool isInventoryOpen = false;

    private void Start()
    {
        inventor.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            isInventoryOpen = !isInventoryOpen;
            inventor.SetActive(isInventoryOpen);
        }
    }
    public void Buton()
    {
        inventor.SetActive(false);
        isInventoryOpen = false;
    }
}