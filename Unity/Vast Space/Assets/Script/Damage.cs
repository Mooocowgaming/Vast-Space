using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.name == "Orange")
		{
			Debug.LogError ("Hit!");
		}
	}
}