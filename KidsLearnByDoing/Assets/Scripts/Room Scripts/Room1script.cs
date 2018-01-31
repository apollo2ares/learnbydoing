using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room1script : MonoBehaviour {

	public GameObject door;
	public GameObject rect;
	public GameObject tri;

	Rigidbody2D doorRB2D;
	Score score;

	// Use this for initialization
	void Start () {
		doorRB2D = door.GetComponent<Rigidbody2D> ();
		rect.gameObject.SetActive (false);
		tri.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Score.score == 2) {
			door.transform.position = new Vector2 (15.88f, 5);
			rect.gameObject.SetActive (true);
			tri.gameObject.SetActive (true);
		}
	}
}
