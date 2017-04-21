﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Entity _playerEntity;
    private Rigidbody2D _rigidBody;
    private bool _canMove;
    private Vector2 _moveDir;
    private bool _jump;

    public bool Jump
    {
        set { _jump = value; }
    }

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
        _rigidBody.velocity = new Vector2(moveDir.x * _playerEntity.MovementSpeed, _rigidBody.velocity.y);
    }

    public void Jump()
    {
        if (_jump)
        {
            _rigidBody.velocity = new Vector2(0, _playerEntity.JumpPower);
            _jump = false;
        }
    }
}
