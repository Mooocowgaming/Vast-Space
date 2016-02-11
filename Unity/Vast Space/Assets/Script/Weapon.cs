using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

	public Transform spawnPoint;
	public float fireRate = 2.0f; //Ammount of bullets in 1 second.
	public GameObject bullet;
	private float fireCounter = 0.0f;
	public Vector2 recoil;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Shoot ();
	
	}

	void Shoot(){

		if (Input.GetButton("Fire1") && fireCounter <= 0) {
			Instantiate (bullet, spawnPoint.position,spawnPoint.rotation);
			fireCounter = 1.0f;
		}
		if (fireCounter >= 0.0f) {
			fireCounter -= Time.deltaTime * fireRate;
		}
	}
}