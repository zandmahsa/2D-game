using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody2D rb; // variable for the RggidBody2D component
	public  SpriteRenderer Flip; // variable for the SpriteRenderer component
	private Animator anim; // variable for the Animator component

	public int movespeed; // move speed
	public int jumppower; // jump height 
	
	
	private bool onGround; // variable for check if player is on the ground or not
	public Transform groundCheck; // variable which is the onGround is performed
	public float groundCheckRadius; // just radious for groundcheck
	public LayerMask whatIsGround; // layer whih is the ground and player can jump on it
	
	
	[SerializeField]
	Transform bubblepos; // possition of bubbles

	[SerializeField]
	GameObject bubble;// the object for bubble

	
	
	public bool moveleft;// variable to check if player is moving on left
	public bool moveright;// variable to check if player is moving on right
	public float startx, starty;// for find the player's start position on x and start position on y
	private bool isattack;// variable for checking if the player attacks 
	[SerializeField]
	private float attackdelay = .2f; // dellay for shoting bubbles

	
	bool isfacingleft;//when the player is shooting is on the left side or not 

	float horizontal;// variable to take a horizontal position of player
	

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();// Setting the RigidBody2D component
		anim = GetComponent<Animator>();// Setting the Animator component.
		Flip = GetComponent<SpriteRenderer>(); // Setting the SpriteRenderer component.
		startx = transform.position.x; //setting the x possition of player
		starty = transform.position.y; // setting the y possition of player
		
		
    }

	// Update using for physics calculations.
	void FixedUpdate()
	{
		onGround = Physics2D.OverlapCircle(groundCheck.transform.position, groundCheckRadius, whatIsGround);//Checking if character is on the ground
		float x = Input.GetAxis ("Horizontal");// for moving player
        Vector3 move = new Vector3 (x * movespeed, rb.velocity.y, 0f);
        rb.velocity = move; 		
	}
	
    // Update is called once per frame
    void Update()
    {	
		if(moveright || Input.GetKey(KeyCode.RightArrow))// move right
		{
			float x = Input.GetAxis ("Horizontal");
       		Vector3 move = new Vector3 (x * movespeed, rb.velocity.y, 0f);
        	rb.velocity = move;
			
			anim.SetBool("ismoving", true); // animation for walking
			Flip.flipX = false; // do not flip the player when is going to the right side
			isfacingleft = false; 
		}
		else if(moveleft || Input.GetKey(KeyCode.LeftArrow)) // move left
		{
			float x = Input.GetAxis ("Horizontal");
       		Vector3 move = new Vector3 (x * -movespeed, rb.velocity.y, 0f);
        	rb.velocity = move;
			
			anim.SetBool("ismoving", true);
			Flip.flipX = true;//do flip the player when is going to the left side
			isfacingleft = true;
		}
		
		//idle
		else{
			anim.SetBool("ismoving",false);// player is not moving
		}
		
		// jump
		if(Input.GetKey(KeyCode.Space) && onGround)
		{
			jump();
			anim.SetBool("jump",true);
		}
		else
			anim.SetBool("jump",false);
			

		//attack
		if(Input.GetKey(KeyCode.Mouse0) || Input.GetKey(KeyCode.LeftControl))
		{
			if(isattack) return;
			//attack and shoot
			anim.Play("attack4");
			isattack = true;

			//instantiate and shoot and attack
			GameObject b = Instantiate(bubble);
			b.GetComponent<bubblescript>().startshoot(isfacingleft);
			b.transform.position = bubblepos.transform.position;

			Invoke("resetattack", attackdelay);
		}

		
    }	

	void resetattack()// end of the attack
	{
		isattack = false;
		anim.Play("idle");
	}

	public void jump()
	{
		if(onGround){
			rb.velocity = new Vector2(rb.velocity.x,jumppower);
		}
	}

	
}
