using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs : MonoBehaviour {

    private PlayerMovement _movement;
    private PlayerShoot _shoot;
    private float _x;
    private Vector2 _moveDir;

	void Awake () {
        _movement = GetComponent<PlayerMovement>();
        _shoot = GetComponentInChildren<PlayerShoot>();
	}	

	void Update () {
        PcControls();
        ControllerControls();
	}

    void PcControls()
    {
        if (_movement.CanMove)
        {
            if (Input.GetButton(InputAxes.PC_MOVEHORIZONTAL))
            {
                _x = Input.GetAxis(InputAxes.PC_MOVEHORIZONTAL);
                _movement.Move(new Vector2(_x,0));
            }
            else
            {
                _movement.Move(new Vector2(0, 0));
            }

            if (Input.GetButtonDown(InputAxes.PC_JUMP))
            {
                _movement.Jump();
            }
        }

        if (Input.GetButton(InputAxes.PC_ATTACK))
        {
            _shoot.Shoot();
        }
    }

    void ControllerControls()
    {
        if (_movement.CanMove)
        {
            if (Input.GetAxis(InputAxes.CON_MOVEHORIZONTAL) != 0)
            {
                _x = Input.GetAxis(InputAxes.CON_MOVEHORIZONTAL);
                _movement.Move(new Vector2(_x,0));
            }
            else
            {
                //_movement.Move(new Vector2(0,0));
            }

            if (Input.GetButtonDown(InputAxes.CON_JUMP))
            {
                //Jump
            }
        }

        if (Input.GetButton(InputAxes.CON_CROUCH))
        {
            //Crouch
        }

        if (Input.GetButton(InputAxes.CON_ATTACK))
        {
            //Fire
        }
    }
}
