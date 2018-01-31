using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterJump : MonoBehaviour {

	public float fallMultiplier = 2.5f;
	public float lowJumpMulitplier = 2f;

	Rigidbody2D rb2D;

	void Awake(){
		rb2D = GetComponent<Rigidbody2D> ();
	}

	void Update(){

		if (rb2D.velocity.y < 0) {
			rb2D.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
		} else if (rb2D.velocity.y > 0 && ! Input.GetKey(KeyCode.Space)) {
			rb2D.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMulitplier - 1) * Time.deltaTime;
		}
	}

}
