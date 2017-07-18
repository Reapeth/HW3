using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartDonut : MonoBehaviour {
	public Text myText;
	// Use this for initialization
	void Start () {
		myText.text = "Enter [SPACE] to start.";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<MeshCollider> ().enabled = false;
			myText.text = "";
		}
	}
}
