using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform shotPos;
    public GameObject bullet;

    public void Guns()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bullet, shotPos.transform.position, transform.rotation);
        }
    }
}
