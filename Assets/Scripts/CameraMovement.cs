using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public Transform player;

	// Update is called once per frame
	void Update () {
		if (player != null) {
			Vector3 targetPos = player.position;
			targetPos.z = transform.position.z;

			if (targetPos.y + Constants.BORDER_FOLLOW_Y >= Constants.SPACEBOUNDARY_Y || targetPos.y - Constants.BORDER_FOLLOW_Y <= -Constants.SPACEBOUNDARY_Y) {
				targetPos.y = transform.position.y;
			}
			if (targetPos.x + Constants.BORDER_FOLLOW_X >= Constants.SPACEBOUNDARY_X || targetPos.x - Constants.BORDER_FOLLOW_X <= -Constants.SPACEBOUNDARY_X) {
				targetPos.x = transform.position.x;
			}

			transform.position = targetPos;
		}
	}
}
