using UnityEngine;
using System.Collections;

public class CameraTrackingPlayer : MonoBehaviour {

	Transform player;	//will hold player (x, y) position

	// camera boundries
	float min_x = 8; float max_x = 32;
	float min_y = 5; float max_y = 14;

	// Use this for initialization
	void Start () {
		//Get the player game object
		GameObject player_object = GameObject.FindGameObjectWithTag ("Player");

		//Validate player exists
		if (player_object == null) {
			Debug.LogError ("Player game object not found");
			return;
		}
		else
			player = player_object.transform;
	}
	
	// Update is called once per frame
	void Update(){
		if (player != null) {
			Vector3 cameraPos = transform.position;
			cameraPos.x = Mathf.Clamp (player.position.x, min_x, max_x);
			cameraPos.y = Mathf.Clamp (player.position.y, min_y, max_y);
			transform.position = cameraPos;
		}
	}
}
