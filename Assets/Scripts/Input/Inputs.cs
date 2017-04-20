using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs : MonoBehaviour {

    private PlayerMovement _movement;
    private float _x;
    private Vector2 _moveDir;

	void Awake () {
        _movement = GetComponent<PlayerMovement>();
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
        }
    }
}
