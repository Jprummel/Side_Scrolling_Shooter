using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knockback : MonoBehaviour {

    private Rigidbody2D _rgb2d;

	void Start () {
        _rgb2d = GetComponent<Rigidbody2D>();
	}
	
    public void AddKnockback(float theForce, Vector2? dir = null, Vector3? source = null)
    {
        if (source != null)
        {
            Vector2 forcePos = transform.position - source.Value;
            Vector2 clampedPos = forcePos.normalized;
            _rgb2d.AddForce(theForce * (clampedPos), ForceMode2D.Impulse);
        }
        else if(dir != null)
        {
            _rgb2d.AddForce(theForce * dir.Value, ForceMode2D.Impulse);
        }
        else
        {
            Debug.LogWarning("You must either give a direction or a source position");
        }
    }
}
