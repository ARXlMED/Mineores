using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab; 
    public Transform shootPosition; 
    public float shootDelay = 0.1f; 
    public float speed;
    public static int bulletint = 0;

    private bool shooting = false;
    private float shootTimer = 0f;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            shooting = true;
        }
        else
        {
            shooting = false;
        }

        if (shooting && bulletint >= 0)
        {
            if (shootTimer <= 0f)
            {
                Shoot();
                shootTimer = shootDelay;
            }
            else
            {
                shootTimer -= Time.deltaTime;
            }
        }
        else
        {
            shootTimer = 0f;
        }
    }

    void Shoot()
    {
        GameObject bulletObject = Instantiate(bulletPrefab, shootPosition.position, shootPosition.rotation);
        Rigidbody bulletBody = bulletObject.GetComponent<Rigidbody>();
        bulletBody.velocity = shootPosition.forward * speed; // скорость пули
        Destroy(bulletObject, 5f); // время, через которое пуля исчезнет
    }
}