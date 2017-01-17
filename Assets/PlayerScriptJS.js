#pragma strict

var x : int = 5;

function Start () {
		Debug.Log("hello world -> " + x);
}

function Update () {
		if (Input.GetButtonUp("Jump")){
			Debug.Log("Jumped!");
		}

		var x : float = Input.GetAxis("Horizontal");
		transform.Translate(x * 0.2, 0, 0);
}
function OnCollisionEnter (obj : Collision) {
		if (obj.gameObject.name == "RightWall"){
				Debug.Log("Hit R!");
		}

}
