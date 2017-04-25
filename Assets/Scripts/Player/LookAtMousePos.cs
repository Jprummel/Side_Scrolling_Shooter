using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMousePos : MonoBehaviour {

    [SerializeField]private GameObject[] _objectsToAim;
    private SpriteRenderer _bodySprite;

    // Use this for initialization
    void Awake() {
        _bodySprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update() {
        LookAtMouse();
    }

    void LookAtMouse()
    {
        for (int i = 0; i < _objectsToAim.Length; i++)
        {
            Vector3 mouseToScreenPos = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
            float angle = Mathf.Atan2(mouseToScreenPos.y, mouseToScreenPos.x) * Mathf.Rad2Deg;
            _objectsToAim[i].transform.rotation = Quaternion.Euler(0, 0, Mathf.Clamp(angle, -180, 180));

            if (angle > 90 || angle < -90)
            {

                FlipSprite(true);
            }
            else
            {
                FlipSprite(false);
            }
        }
    }

    void FlipSprite(bool dir)
    {
        Quaternion bodyRotation = transform.rotation;

        for (int i = 0; i < _objectsToAim.Length; i++)
        {
            _objectsToAim[i].GetComponentInChildren<SpriteRenderer>().flipY = dir;
        }

        if (dir)
        {
            bodyRotation.y = 180;
        }
        else
        {
            bodyRotation.y = 0;
        }
        
    }
}
