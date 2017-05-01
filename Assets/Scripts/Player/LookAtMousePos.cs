using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMousePos : MonoBehaviour {

    [SerializeField]private GameObject[] _objectsToAim;
    private SpriteRenderer _bodySprite;
    private float _minClamp;
    private float _maxClamp;
    bool _flipped;
    
    void Awake() {
        _bodySprite = GetComponent<SpriteRenderer>();
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
            if (_flipped)
            {
                Debug.Log("ay");
                _minClamp = 120;
                _maxClamp = 280;
            }
            else
            {
                Debug.Log("Lmao");
                _minClamp = -70;
                _maxClamp = 70;
            }
            _objectsToAim[i].transform.rotation = Quaternion.Euler(0, 0, Mathf.Clamp(angle, _minClamp, _maxClamp));

            if (angle > 90 || angle < -100)
            {

                FlipSprite(true);
            }
            else if( angle > 300 || angle < 90)
            {
                FlipSprite(false);
            }
        }
    }

    void FlipSprite(bool flipped)
    {
        Quaternion bodyRotation = transform.rotation;

        for (int i = 0; i < _objectsToAim.Length; i++)
        {
            _objectsToAim[i].GetComponentInChildren<SpriteRenderer>().flipY = flipped;
        }

        if (flipped)
        {
            bodyRotation.y = 180;
            _flipped = true;
        }
        else
        {
            bodyRotation.y = 0;
            _flipped = false;
        }
    }
}
