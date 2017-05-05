using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    [SerializeField]private Vector2 _velocity;
    [SerializeField]private float _smoothTimeX;
    [SerializeField]private float _smoothTimeY;
    [SerializeField]private Transform _player;

	void FixedUpdate () 
    {
        float posX = Mathf.SmoothDamp(transform.position.x, _player.position.x, ref _velocity.x, _smoothTimeX);
        float posY = Mathf.SmoothDamp(transform.position.y, _player.position.y, ref _velocity.y, _smoothTimeY);

        transform.position = new Vector3(posX, posY, transform.position.z);
	}
}
