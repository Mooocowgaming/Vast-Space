using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	[HideInInspector]
	public float bulletSpeed = 0.0f;
	public int directionPointing = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate (){

		transform.Translate (Vector3.right * (bulletSpeed*directionPointing));

	}
}
