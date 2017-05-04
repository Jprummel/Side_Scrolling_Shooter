using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour {

    [SerializeField]private List<Transform> _partsToAim = new List<Transform>();
    private Transform _mousePosition;
    private BodyRotation _bodyRotation;
    private Targeting _targeting;

	void Start () {
        _bodyRotation = GetComponent<BodyRotation>();
        _targeting = GetComponent<Targeting>();
        _mousePosition = GameObject.FindGameObjectWithTag(Tags.CURSOR).GetComponent<Transform>();
	}
	
	void Update () {
        _targeting.LookAtTarget(_mousePosition, _partsToAim);
	}
}