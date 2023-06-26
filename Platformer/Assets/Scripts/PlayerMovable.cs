using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovable : MonoBehaviour
{
    [SerializeField] private Transform groundPoint;
    [SerializeField] private LayerMask groundLayer;

    private Rigidbody2D rb;

    private float speed = 7f;
    private float jumpForce = 5f;

    private float moveInput;
    private float flipValue;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if(moveInput != 0) flipValue = FlipValue(moveInput);
        transform.eulerAngles = VectorFlip(flipValue);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) Jump();
    }

    private void Jump()
    {
        if(Ground()) rb.velocity = Vector2.up * jumpForce;
    }

    private Vector3 VectorFlip(float count)
    {
        Vector3 vector = new Vector3(0, count, 0);
        return vector;
    }

    private float FlipValue(float count)
    {
        if (count > 0) return 180;
        return 0;
    }

    private Collider2D Ground()
    {
        return Physics2D.OverlapCircle(groundPoint.position, 0.25f, groundLayer);
    }
}
