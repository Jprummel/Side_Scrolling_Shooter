using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knockback : MonoBehaviour {

    private Rigidbody2D _rgb2d;

	void Start () {
        _rgb2d = GetComponent<Rigidbody2D>();
	}
	
    public void AddKnockback(float theForce, Vector3? source = null)
    {
        if (source != null)
        {
            Vector2 forcePos = transform.position - source.Value;
            Vector2 clampedPos = forcePos.normalized;
            _rgb2d.AddForce(theForce * (clampedPos), ForceMode2D.Impulse);
        }
        else
        {
            _rgb2d.AddForce(theForce * Vector2.left, ForceMode2D.Impulse);
        }
    }
}
