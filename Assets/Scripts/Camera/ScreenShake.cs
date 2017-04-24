﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour {

    private Vector3 _defaultPos;
    private float _intensity;
    private float _duration;
	// Use this for initialization
	void Start () {
        _defaultPos = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (_duration >= 0)
        {
            Vector2 shakePos = Random.insideUnitCircle * _intensity;
            transform.position = new Vector3(transform.position.x + shakePos.x, transform.position.y + shakePos.y, transform.position.z);
            Debug.Log("Ay");
            _duration -= Time.deltaTime;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Shake(0.1f, 1);
        }
	}

    public void Shake(float intensity, float duration)
    {
        _defaultPos = this.transform.position;
        _duration = duration;
        _intensity = intensity;

        /*while (duration >= 0) {
            Vector2 shakePos = Random.insideUnitCircle * intensity;
            transform.position = new Vector3(transform.position.x  + shakePos.x, transform.position.y + shakePos.y,transform.position.z);
            Debug.Log("Ay");
            duration -= Time.deltaTime;
        }*/
    }
}