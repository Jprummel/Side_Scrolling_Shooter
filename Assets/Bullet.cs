using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    private float _speed = 5;
    private Rigidbody2D _rgb2d;

	// Use this for initialization
	void Start () {
        _rgb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        _rgb2d.AddForce(transform.right * _speed);
	}
}
