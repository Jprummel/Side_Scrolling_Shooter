using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMousePos : MonoBehaviour {

    [SerializeField]private GameObject[] _objectsToAim;
    private Quaternion _bodyRotation;
    private float _minClamp = -360;
    private float _maxClamp = 360;
    bool _flipped;
    private Quaternion _turnedRotation = Quaternion.Euler(0, 180, 0);

    void Awake()
    {
        _bodyRotation = transform.rotation;
    }

    void Update() {
        LookAtMouse();
    }

    void LookAtMouse()
    {
        for (int i = 0; i < _objectsToAim.Length; i++)
        {
            Vector3 mouseToScreenPos    = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
            Quaternion objectRotation   = _objectsToAim[i].transform.rotation;
            float angle = Mathf.Atan2(mouseToScreenPos.y, mouseToScreenPos.x) * Mathf.Rad2Deg;
            //Debug.Log(angle);
            if (_flipped)
            {
                //_minClamp = -170;
                //_maxClamp = 170;
            }
            else
            {
                //_minClamp = -70;
                //_maxClamp = 70;
            }
            _objectsToAim[i].transform.rotation = Quaternion.Euler(0, 0, Mathf.Clamp(angle, _minClamp, _maxClamp));

            if (angle > 90 || angle < -90)
            {  
                //FlipSprite(true);
            }
            /*else if( angle > -90)
            {
                FlipSprite(false);
            }*/ 
        }
    }

    void FlipSprite(bool flipped)
    {
        if (flipped)
        {
            transform.rotation = _turnedRotation;

            for (int i = 0; i < _objectsToAim.Length; i++)
            {
                _objectsToAim[i].transform.rotation = _turnedRotation;
            }
            _flipped = true;
        }
        else
        {
            transform.rotation = Quaternion.identity;

            for (int i = 0; i < _objectsToAim.Length; i++)
            {
                _objectsToAim[i].transform.rotation = Quaternion.identity;
            }
            _flipped = false;
        }
    }
}
