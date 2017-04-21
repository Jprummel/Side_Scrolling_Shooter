using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour {

    PlayerMovement _playerMovement;

	void Start () {
        _playerMovement = GetComponentInParent<PlayerMovement>();
	}

    void OnCollisionEnter2D()
    {

    }
	
}
