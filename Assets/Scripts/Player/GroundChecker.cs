using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour {

    PlayerMovement _playerMovement;

	void Start () {
        _playerMovement = GetComponent<PlayerMovement>();
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        _playerMovement.CanJump = true;
    }
	
}
