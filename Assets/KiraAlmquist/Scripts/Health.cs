using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;

    public Animator animator;

    public Image[] hearts;
    public Sprite emptyHeart;
    public Sprite fullHeart;

    public GameObject EnemyUI;

    public GameObject checkpoint;

       
    void Update()
    {
        for(int i = 0; i < hearts.Length; i++)
        {
            if (i < currentHealth)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if (i < maxHealth)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }

        if(currentHealth <- 0)
        {
            Death();
        }
    }

    public void Damage(int damage)
    {
        currentHealth -= damage;
    }

    public void Death()
    {
        if(gameObject.CompareTag("Enemy"))
        {
            GetComponent<EnemyChase>().enabled = false;
            GetComponent<CollisionDamage>().enabled = false;
            GetComponent<CircleCollider2D>().enabled = false;
            animator.Play("DoggoIdle");
            EnemyUI.SetActive(false); 
          
        }

        if(gameObject.CompareTag("Enemy2"))
        {
            GetComponent<EnemyChase>().enabled = false;
            GetComponent<CollisionDamage>().enabled = false;
            GetComponent<CircleCollider2D>().enabled = false;
            animator.Play("Doggo2Idle");
            EnemyUI.SetActive(false);
        }

        if(gameObject.CompareTag("MechaDog"))
        {
            GetComponent<EnemyChase>().enabled = false;
            GetComponent<CollisionDamage>().enabled = false;
            GetComponent<CapsuleCollider2D>().enabled = false;
            animator.Play("HappyMechaDog");
            EnemyUI.SetActive(false);
        }



        if(gameObject.CompareTag("Props"))
        {
            Destroy(gameObject);
        }
       // if(gameObject.CompareTag("Enemy"))
       // {
       //     Destroy(gameObject);
      //  }

        if (gameObject.CompareTag("Player"))
        {
            gameObject.transform.position = new Vector2(checkpoint.transform.position.x, checkpoint.transform.position.y);
            currentHealth = maxHealth;
        }
    }
}
