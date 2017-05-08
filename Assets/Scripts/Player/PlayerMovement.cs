using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;

public class PlayerMovement : MonoBehaviour {

    private Entity _playerEntity;
    private SkeletonAnimation _spineAnimation; 
    private Rigidbody2D _rigidBody;
    private bool _canMove;
    private Vector2 _moveDir;
    private bool _jump = true;
    private bool _isMoving = false;

    public bool IsMoving
    {
        get { return _isMoving; }
        set { _isMoving = value; }
    }

    public bool CanJump
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
        _spineAnimation = GetComponent<SkeletonAnimation>();
	} 

    public void Move(Vector2 moveDir)
    {
        _rigidBody.velocity = new Vector2(moveDir.x * _playerEntity.MovementSpeed, _rigidBody.velocity.y);
        if (_isMoving)
        {
            //_spineAnimation.AnimationName = "walk";
        }
        else
        {
            //_spineAnimation.AnimationName = "idle";
        }
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
