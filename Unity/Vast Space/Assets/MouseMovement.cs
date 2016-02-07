using UnityEngine;
using System.Collections;

public class MouseMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Input.mousePosition;
	}
	
	// Update is called once per frame
	void Update () {

		transform.RotateAround (Input.mousePosition);
	
	}
}
