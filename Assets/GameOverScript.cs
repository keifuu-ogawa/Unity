using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour {

public GUIStyle style;

	void OnGUI () {
			GUI.Label(new Rect(10, 10, 200, 50), "Game Over", style);
	}
}
