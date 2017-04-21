using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    private Rigidbody2D _rigidBody;
    private bool _canMove;

    private float _speed;
    [SerializeField]    private Vector2 _startPos;
    [SerializeField]    private Vector2 _endPos;

    // Use this for initialization
    void Start () {
        _speed = 1f;
	}
	
	// Update is called once per frame
	void Update () {
        float step = _speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, _endPos, step);
    }
}
