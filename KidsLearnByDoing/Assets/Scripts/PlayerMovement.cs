using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed = 10f;
	public float jumpSpeed = 15f;
	public float jumpsLeft = 1f;
	public bool canMove;

	public GameObject door;
	public GameObject rect;
	public GameObject tri;


	Rigidbody2D rb2D;
	Rigidbody2D doorRB2D;
	Score score;

	// Use this for initialization
	void Start () {
		canMove = true;
		rb2D = GetComponent<Rigidbody2D> ();
		doorRB2D = door.GetComponent<Rigidbody2D> ();
		rect.gameObject.SetActive (false);
		tri.gameObject.SetActive (false);
	}


	//Movement function
	void Move(float dx){
		rb2D.velocity = new Vector2 (dx * moveSpeed, rb2D.velocity.y);
	}


	// Update is called once per frame
	void Update () {
		float xMove = Input.GetAxis ("Horizontal");
		//float yMove = Input.GetAxis ("Vertical");

		if (canMove) {
			Move (xMove);
		} else {
			Move (0);
		}

		//jumping!
		if (Input.GetKeyDown (KeyCode.Space)&&jumpsLeft>0) {
			rb2D.velocity = new Vector2 (rb2D.velocity.x, jumpSpeed);
			jumpsLeft--;
		}
			
	}

	//resetting jumps when you hit a platform
	void OnCollisionEnter2D (Collision2D other){
		if (jumpsLeft <= 0) {
			jumpsLeft = 1f;
		}

		if (other.gameObject.name == "Floor") {
			rb2D.velocity = new Vector2 (rb2D.velocity.x, 0);
		}


		//picking up puzzle pieces
		if (other.gameObject.tag.Contains("puzzle")){
			
			Destroy (other.gameObject);
			Score.score++;
		}
	}

	//making it so you can't jump if you're not on a platform
	void OnCollisionExit2D (Collision2D collision){
		jumpsLeft = 0;
	}
}
