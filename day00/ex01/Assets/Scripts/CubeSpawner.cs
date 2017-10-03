using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour {

	public GameObject	blockA;
	public GameObject	blockS;
	public GameObject	blockD;

	public int	rand;

	// Update is called once per frame
	void Update () {
		//Precision correspond to the distance between the square and the line when the player presses the key
		//GameObject.Instantiate(
		rand = Random.Range(0, 300);
		if (rand == 84) {
			GameObject.Instantiate (blockA, new Vector3 (-1.18f, 1.94f, 0.0f), Quaternion.identity);
		}
		if (rand == 42) {
			GameObject.Instantiate (blockS, new Vector3 (0.00f, 1.94f, 0.0f), Quaternion.identity);
		}
		if (rand == 178) {
			GameObject.Instantiate (blockD, new Vector3 (1.18f, 1.94f, 0.0f), Quaternion.identity);
		}

	}
}
