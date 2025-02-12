using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;
    public LayerMask groundLayer;
    public float moveSpeed;
    public float jumpSpeed;
    private bool grounded = false;
    private float horizontal;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if (horizontal > 0) transform.localScale = Vector3.one;
        else if (horizontal < 0) transform.localScale = new Vector3(-1,1,1);

        if (Input.GetButtonDown("Jump") && grounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * moveSpeed, rb.velocity.y);

        grounded = Physics2D.CircleCast(transform.position, 1.0f, Vector2.down, 0.05f);
    }

}
