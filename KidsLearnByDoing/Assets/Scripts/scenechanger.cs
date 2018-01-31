using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechanger : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		Application.LoadLevel (1);
		Debug.Log ("tested");
	}

}
