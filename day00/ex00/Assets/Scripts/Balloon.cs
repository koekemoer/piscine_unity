using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour {

	public int	breath;
	public int	time;

	// Use this for initialization
	void Start () {
		Debug.Log ("INIT");
		breath = 100;
		time = 0;
	}
	
	// Update is called once per frame
	void Update () {
		time++;
		if (transform.localScale.x > 10.0f) {
			GameObject.Destroy (gameObject);
			Debug.Log ("Balloon Lifetime: " + time);
		}
		if (transform.localScale.x > 0.2f)
			transform.localScale -= new Vector3 (0.02f, 0.02f, 0);
		if (transform.localScale.x < 0.2f) {
			GameObject.Destroy (gameObject);
			Debug.Log ("Balloon Lifetime: " + time);
		}
		
		if (Input.GetKeyDown (KeyCode.Space)) {
			Debug.Log ("SPACE PRESSED");
			if (breath > 10)
			{
				breath -= 10;
				if (transform.localScale.x < 10.0f) 
				{
					transform.localScale += new Vector3 (0.3f, 0.3f, 0);
				}
			}
		}
		if (breath < 100) breath += 1;
		//if (Input.GetKeyDown(KeyCode.Escape))
			
	}
}
