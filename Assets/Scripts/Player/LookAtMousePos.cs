﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMousePos : MonoBehaviour {

    [SerializeField]private GameObject[] _objectsToAim;
    [SerializeField]private List<SpriteRenderer> _sprites;
    private Quaternion _bodyRotation;
    [SerializeField]private float _minClamp;
    [SerializeField]private float _maxClamp;
    bool _flipped;
    private Quaternion _turnedRotation = Quaternion.Euler(0, 180, 0);
    //Vectors
    private Vector3 _targetPosition;
    private Vector3 _thisObjectPosition;
    private Vector3 _positionDifference;

    void Awake()
    {
        _bodyRotation = transform.rotation;
    }

    void Update() {
        //LookAtMouse();
        Aim();
    }

    void Aim()
    {
        _targetPosition = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        _thisObjectPosition = transform.position;
        _positionDifference = _targetPosition - _thisObjectPosition;

        for (int i = 0; i < _objectsToAim.Length; i++)
        {
            float angle = Mathf.Atan2(_targetPosition.y,_targetPosition.x) * Mathf.Rad2Deg;
            _objectsToAim[i].transform.rotation = Quaternion.Euler(0, 0, Mathf.Clamp(angle, _minClamp, _maxClamp));
            if (_positionDifference.x > 0)
            {
                _flipped = true;
                Flip(_flipped);
                //_sprites[0].flipY = true;
            }
            else if (_positionDifference.x < 0)
            {
                _flipped = false;
                Flip(_flipped);
                //_sprites[0].flipY = false;
            }
        }
    }

    void LookAtMouse()
    {
        for (int i = 0; i < _objectsToAim.Length; i++)
        {
            Vector3 mouseToScreenPos    = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
            Quaternion objectRotation   = _objectsToAim[i].transform.rotation;
            float angle = Mathf.Atan2(mouseToScreenPos.y, mouseToScreenPos.x) * Mathf.Rad2Deg;
            //Debug.Log(angle);
            if (_flipped)
            {
                _minClamp = -170;
                _maxClamp = 170;
            }
            else
            {
                _minClamp = -70;
                _maxClamp = 70;
            }
            _objectsToAim[i].transform.rotation = Quaternion.Euler(0, 0, Mathf.Clamp(angle, _minClamp, _maxClamp));

            if (angle > 90 || angle < -90)
            {  
                //FlipSprite(true);
            }
            else if( angle > -90)
            {
                //FlipSprite(false);
            } 
        }
    }

    void Flip(bool flipped)
    {
        if (flipped)
        {
            _minClamp = -35;
            _maxClamp = 60;
        }
        else
        {

        }
    }

    void FlipSprite(bool flipped)
    {
        if (flipped)
        {
            transform.rotation = _turnedRotation;

            for (int i = 0; i < _objectsToAim.Length; i++)
            {
                _objectsToAim[i].transform.rotation = _turnedRotation;
            }
            _flipped = true;
        }
        else
        {
            transform.rotation = Quaternion.identity;

            for (int i = 0; i < _objectsToAim.Length; i++)
            {
                _objectsToAim[i].transform.rotation = Quaternion.identity;
            }
            _flipped = false;
        }
    }
}
