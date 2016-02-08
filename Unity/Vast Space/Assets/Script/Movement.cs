using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float moveSpeed = 8.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Translate (0f, moveSpeed * Input.GetAxis ("Vertical") * Time.deltaTime, 0f);
	
		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
	}
}

