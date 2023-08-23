using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
{
    public int damage;

    // Start is called before the first frame update
    
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.CompareTag("Player"))
        {
            coll.gameObject.GetComponent<Health>().Damage(damage);
        }
    }
}
