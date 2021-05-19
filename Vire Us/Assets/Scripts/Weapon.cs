using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float fireRate = 0;
    public float Damage = 10;

    float timeToFire = 0;
    public Transform firePoint;
    public GameObject bulletPrefab;

    
    // Update is called once per frame
    void Update()
    {
        if (fireRate == 0)
        {
            if (Input.GetButtonDown ("Fire1"))
            {
                Shoot();
            }
        }
        else
        {
            if (Input.GetButton ("Fire1") && Time.time > timeToFire)
            {
                timeToFire = Time.time + 1 / fireRate;
                Shoot();    
            }
        }
    }
    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
