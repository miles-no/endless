using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce;
    public float moveSpeed;
    public bool grounded;
    public LayerMask groundLayer;

    private Rigidbody2D rigidBody;
    private Collider2D collider;
    private Animator animator;

	// Use this for initialization
	void Start ()
	{
	    rigidBody = GetComponent<Rigidbody2D>();
	    collider = GetComponent<Collider2D>();
	    animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    grounded = Physics2D.IsTouchingLayers(collider, groundLayer);

		rigidBody.velocity = new Vector2(moveSpeed, rigidBody.velocity.y);

	    if (grounded && (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)))
	    {
	        rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpForce);
	    }

        animator.SetFloat("Speed_X", rigidBody.velocity.x);
	    animator.SetFloat("Speed_Y", rigidBody.velocity.y);
        animator.SetBool("Grounded", grounded);
    }
}
