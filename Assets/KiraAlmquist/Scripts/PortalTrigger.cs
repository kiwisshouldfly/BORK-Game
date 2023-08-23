using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalTrigger : MonoBehaviour
{
    public string sceneToLoad;

    public bool playerInRange;
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collision)
    {
        print("portal activated");
        if (collision.gameObject.CompareTag("Player"))
        {
            playerInRange = true;
            PortalTeleport();
        }
        
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }

    public void PortalTeleport()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}