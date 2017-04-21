using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    private Entity _enemyEntity;

    private Rigidbody2D _rigidBody;
    private bool _switch;

    [SerializeField]    private Vector3 _startPos;
    [SerializeField]    private Vector3 _endPos;

    // Use this for initialization
    void Start () {
        _enemyEntity = GetComponent<Entity>();
	}
	
	// Update is called once per frame
	void Update () {

        float step = _enemyEntity.MovementSpeed * Time.deltaTime;

        if (transform.position == _startPos)
        {
            _switch = false;
        }
        else if (transform.position == _endPos)
        {
            _switch = true;
        }

        if (!_switch)
        {
            transform.position = Vector3.MoveTowards(transform.position, _endPos, step);
        }
        else if (_switch)
        {
            transform.position = Vector3.MoveTowards(transform.position, _startPos, step);
        }
    }
}
