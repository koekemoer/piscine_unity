using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		const float precision = 2.0f;
		float distance;
		float perc = 0;
		float speed = Random.Range (-0.02f, -0.08f);
		transform.Translate(0f, speed, 0f); //translate values into movement?

		if (transform.localPosition.y < -2.2f)
			GameObject.Destroy (gameObject);
		if (Input.GetKeyDown (KeyCode.A) && transform.localPosition.x < 0) 
		{
			distance = precision + transform.localPosition.y;
			if (distance < 0)
				distance *= -1;
			//distance = 100 - distance;
			if (transform.localPosition.y < -1.5) {
				perc = 100 - (distance * 100);
				GameObject.Destroy (gameObject);
				Debug.Log ("Precision: " + perc + "%");
			}
		}
		if (Input.GetKeyDown (KeyCode.S) && transform.localPosition.x == 0) 
		{
			//precision *= -1;
			distance = precision + transform.localPosition.y;
			if (distance < 0)
				distance *= -1;
			//distance = 100 - distance;
			if (transform.localPosition.y < -1.5) {
				perc = 100 - (distance * 100);
				GameObject.Destroy (gameObject);
				Debug.Log ("Precision: " + perc + "%");
			}
		}
		if (Input.GetKeyDown (KeyCode.D) && transform.localPosition.x > 0) 
		{
			//precision *= -1;
			distance = precision + transform.localPosition.y;
			if (distance < 0)
				distance *= -1;
			//distance = 100 - distance;
			if (transform.localPosition.y < -1.5) {
				perc = 100 - (distance * 100);
				GameObject.Destroy (gameObject);
				Debug.Log ("Precision: " + perc + "%");
			}
		}
		
	}
}
