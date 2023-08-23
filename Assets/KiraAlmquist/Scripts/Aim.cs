using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    //public float movementSpeed = 5f; old code
    public Rigidbody2D rb;
    public Camera cam;
    public GameObject player;
    public float offsetX;
    public float offsetY;

    Vector2 mousePos;
    // Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //movement.x = Input.GetAxisRaw("Horizontal");
        // movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        rb.transform.position = new Vector2(player.transform.position.x, player.transform.position.y);
    }

    void FixedUpdate()
    {
        // rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
