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
            _bodyRotation.y = 180; //stores a rotation value
            _body.rotation = _bodyRotation; //Flips body
        }
        else
        {
            _bodyRotation.y = 0; //sets rotation value back to default
            _body.rotation = _bodyRotation; //Flips body back to default rotation
        }
    }
}
