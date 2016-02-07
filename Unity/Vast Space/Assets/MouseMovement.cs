using UnityEngine;
using System.Collections;

public class MouseMovement : MonoBehaviour {
	//private Vector3 mousePosition;
	//public float moveSpeed = 0.1f;
	public GameObject Player;
	public float rotateSpeed = 2.1f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//mousePosition = Input.mousePosition;
		//mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
		//transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
			//Get the Screen positions of the object
			Vector2 positionOnScreen = Camera.main.WorldToViewportPoint (transform.position);

			//Get the Screen position of the mouse
			Vector2 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);

			//Get the angle between the points
			float angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);

			//Ta Daaa
			transform.rotation =  Quaternion.Euler (new Vector3(0f,0f,angle));
		}

		float AngleBetweenTwoPoints(Vector3 a, Vector3 b) {
			return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
	}
}
