using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBoxScript : MonoBehaviour {

public Transform ball;
int x = 0;

	void Update () {
		if (Input.GetButtonUp("Jump")){
			Instantiate(ball, transform.position, transform.rotation);
			x++;
		}

		if (x > 10) {
			Application.LoadLevel("GameOver");
		}
	}
}
