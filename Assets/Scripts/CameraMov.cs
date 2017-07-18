using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMov : MonoBehaviour {
	Vector3 ballPos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ballPos = GameObject.Find ("Ball").GetComponent<Transform> ().position;
		GetComponent<Transform> ().position = new Vector3 (ballPos.x, ballPos.y + 7.5f, ballPos.z - 10);
	}
}
