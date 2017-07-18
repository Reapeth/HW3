using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donutvator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	/*void OnCollisionEnter(Collision collision){
		if (collision.gameObject.name == "Ball"){
			GetComponent<ConstantForce> ().relativeForce = new Vector3 (0, 15, 0);
		}
	}*/
	void OnCollisionStay(Collision collision){
		if (collision.gameObject.name == "Ball"){
			GetComponent<ConstantForce> ().relativeForce = new Vector3 (0, 15, 0);
		}
		if (collision.gameObject.name == "RightRail") {
			GetComponent<ConstantForce> ().relativeForce = new Vector3 (20,GetComponent<ConstantForce> ().relativeForce.y,GetComponent<ConstantForce> ().relativeForce.z);
		}
	}
}
