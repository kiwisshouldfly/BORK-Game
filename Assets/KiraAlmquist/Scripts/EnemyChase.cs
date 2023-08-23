using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public GameObject player;
    public float moveSpeed;

    public Animator animator;

    private Radar radar;

    private SpriteRenderer spriteRenderer;

    public bool flipped;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        radar = GetComponentInChildren<Radar>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

   
      
        if(radar.playerInRange == true)
        {
            MoveToPlayer();
            FacePlayer();
            animator.SetBool("WithinRange", true);
   
        }

        if(radar.playerInRange == false)
        {
            animator.SetBool("WithinRange", false);
        }
        
       
    }

    public void MoveToPlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.deltaTime);
    }

    private void FacePlayer()
    {
        if (radar.playerInRange == true)
        {
            flipped = player.transform.position.x < transform.position.x;
            spriteRenderer.flipX = flipped;
        }
    }

}
