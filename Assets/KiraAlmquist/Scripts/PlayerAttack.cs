using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject playerBulletPrefab;
    public Transform nozzle;

    public float bulletForce = 20f;

    public AudioSource audioSource;
    public AudioClip bulletSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
  

    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
           
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(playerBulletPrefab, nozzle.position, nozzle.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(nozzle.up * bulletForce, ForceMode2D.Impulse);
        audioSource.PlayOneShot(bulletSound);

    }
}
