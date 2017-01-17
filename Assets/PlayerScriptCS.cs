using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScriptCS : MonoBehaviour {

int x = 5;

	// Use this for initialization
	void Start () {
			Debug.Log("hello world -> " + x);
	}

	// Update is called once per frame
	void Update () {
			//transform.position += new Vector3(0, 0, 0.1f);
			//transform.Translate(0, 0, 0.1f);

			if (Input.GetButtonUp("Jump")){
				Debug.Log("Jumped!");
			}

			var x = Input.GetAxis("Horizontal");
			transform.Translate(x * 0.2f, 0, 0);
	}

	void OnCollisionEnter (Collision obj) {
			if (obj.gameObject.name == "RightWall"){
					Debug.Log("Hit R!");
				}
	}
}
