using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform shotPos;
    public GameObject bullet;

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Instantiate(bullet, shotPos.transform.position, transform.rotation);
        }
    }
}
