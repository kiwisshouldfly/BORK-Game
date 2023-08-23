using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Animator animator;

    public float movementSpeed = 5;
    public Rigidbody2D rb;

    Vector2 movement;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        // horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        // animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if(movement != Vector2.zero)
        {
            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
        }

      
       animator.SetFloat("Speed", movement.sqrMagnitude);

        //Debug.Log(Input.mousePosition);
        //Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);
    }
}


