using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour {

    [SerializeField]private List<Transform> _partsToAim = new List<Transform>();
    private Transform _mousePosition;
    private BodyRotation _bodyRotation;
    private float _angle;

    private float _minClamp;
    private float _maxClamp;

	void Start () {
        _bodyRotation = GetComponent<BodyRotation>();
        _mousePosition = GameObject.FindGameObjectWithTag(Tags.CURSOR).GetComponent<Transform>();
	}
	
	void Update () {
        Aim();
	}

    void Aim()
    {
        Vector3 worldMousePosition = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        Vector3 difference = worldMousePosition - transform.position;

        if (difference.x < 0)
        {
            _bodyRotation.Flipped = true;
        }
        else if(difference.x > 0)
        {
            _bodyRotation.Flipped = false;
        }

        for (int i = 0; i < _partsToAim.Count; i++)
        {
            Vector3 _difference = _mousePosition.position - _partsToAim[i].position;
            _difference.Normalize();
            float rotZ = Mathf.Atan2(_difference.y, _difference.x) * Mathf.Rad2Deg;
            _angle = Mathf.Atan2(worldMousePosition.y, worldMousePosition.x) * Mathf.Rad2Deg;
            if (_bodyRotation.Flipped)
            {
                _partsToAim[i].rotation = Quaternion.Euler(180, 0, -rotZ);
            }
            else if (!_bodyRotation.Flipped)
            {
                _partsToAim[i].rotation = Quaternion.Euler(0, 0, rotZ);
            }
        }
    }
}
