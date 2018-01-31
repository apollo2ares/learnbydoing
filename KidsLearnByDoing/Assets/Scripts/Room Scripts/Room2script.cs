using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room2script : MonoBehaviour {

	public GameObject door2;
	public GameObject rect2;
	public GameObject tri2;

	Rigidbody2D door2RB2D;
	Score score;

	// Use this for initialization
	void Start () {
		door2RB2D = door2.GetComponent<Rigidbody2D> ();
		rect2.gameObject.SetActive (false);
		tri2.gameObject.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		if (Score.score == 3) {
			door2.transform.position = new Vector2 (36.89f, -7.635f);
			rect2.gameObject.SetActive (true);
			tri2.gameObject.SetActive (true);
		}
	}
}
