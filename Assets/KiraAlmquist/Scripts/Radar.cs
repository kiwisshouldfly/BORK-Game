using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar : MonoBehaviour
{
    public bool playerInRange;

    // Start is called before the first frame update
   
    public void OnTriggerEnter2D(Collider2D collision)
    {
        print("trigger entered");
        if (collision.gameObject.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }
}
