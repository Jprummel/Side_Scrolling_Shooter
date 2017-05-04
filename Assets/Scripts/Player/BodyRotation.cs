using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyRotation : MonoBehaviour {

    private Transform _body;
    private Quaternion _bodyRotation;
    private bool _flipped;

    public float EntityBodyRotation
    {
        get { return _bodyRotation.y; }
    }

    public bool Flipped
    {
        get { return _flipped; }
        set { _flipped = value; }
    }

	void Start () {
        _body = this.transform;
        _bodyRotation = _body.rotation;
	}
	
	void Update () {
        RotateBody();
	}

    void RotateBody()
    {
        if(_flipped){
            _bodyRotation.y = 180;
            Debug.Log(_bodyRotation.y + "Ay");
            _body.rotation = _bodyRotation;
        }
        else
        {
            _bodyRotation.y = 0;
            _body.rotation = _bodyRotation;
        }
    }
}
