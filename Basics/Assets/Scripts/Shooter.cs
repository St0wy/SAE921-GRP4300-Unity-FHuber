using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject laserPrefab;
    public Transform firePoint;
    public float bulletForce = 20f;

    private void Update()
    {
        if (!Input.GetButtonDown("Fire1")) return;

        // Instantiate the bullet
        var bullet = Instantiate(laserPrefab, firePoint.position, firePoint.rotation);

        // Move the bullet.
        var rbBullet = bullet.GetComponent<Rigidbody2D>();
        var force = -firePoint.right * bulletForce;
        rbBullet.AddForce(force, ForceMode2D.Impulse);
    }
}