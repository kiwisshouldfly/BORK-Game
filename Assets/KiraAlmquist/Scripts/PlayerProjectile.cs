using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public GameObject hitEffect;
    public int damage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);

        if(collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Health>().Damage(damage);
            print("owww im an enemy" + damage);
        }

        if(collision.gameObject.CompareTag("Props"))
        {
            collision.gameObject.GetComponent<Health>().Damage(damage);
        }

        if (collision.gameObject.CompareTag("Enemy2"))
        {
            collision.gameObject.GetComponent<Health>().Damage(damage);
            
        }

        if (collision.gameObject.CompareTag("MechaDog"))
        {
            collision.gameObject.GetComponent<Health>().Damage(damage);
        }

        Destroy(effect, 1f);
        Destroy(gameObject);
    }
}
