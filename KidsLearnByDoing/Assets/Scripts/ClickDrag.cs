using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickDrag : MonoBehaviour {

	bool dragging = false;
	float distance;

	public Text winText;

	void OnMouseEnter()
	{

	}

	void OnMouseExit()
	{

	}
	void OnMouseDown()
	{
		distance = Vector3.Distance(transform.position, Camera.main.transform.position);
		dragging = true; 
	}

	void OnMouseUp()
	{
		dragging = false;
	}
	void Start () {
		//GUIText.enabled = false;
	}

	// Update is called once per frame
	void Update () {
		//Vector2 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);

		if (dragging)
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			Vector3 rayPoint = ray.GetPoint(distance);
			transform.position = rayPoint;
		}
	}

	void OnCollisionEnter2D(Collision2D other){
		//GUIText.enabled = true;
	}
}