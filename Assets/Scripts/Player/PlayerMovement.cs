using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Entity _playerEntity;
    private Rigidbody2D _rigidBody;
    private bool _canMove;
    private Vector2 _moveDir;

    public bool CanMove
    {
        get { return _canMove; }
        set { _canMove = value; }
    }

	void Start () {
        _canMove = true;
        _playerEntity = GetComponent<Entity>();
        _rigidBody = GetComponent<Rigidbody2D>();
	}

    public void Move(Vector2 moveDir)
    {
        _rigidBody.MovePosition(_rigidBody.position + moveDir * _playerEntity.MovementSpeed * Time.deltaTime);
    }
}
