using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {
	public int playerHealth = 100;
	public int enemyHealth = 100;
	public GameObject Enemy1;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D(Collision2D coll) //Enemy
	{
		if (coll.gameObject.name == "Orange")
		{
			Debug.LogError ("Hit! -10HP");
			enemyHealth -= 10;	
			Debug.LogError (enemyHealth);

		}
			
		if (enemyHealth <= 0) {
			Debug.LogError ("Enemy Is Dead");
			Destroy (Enemy1);
	
		}
	}
}