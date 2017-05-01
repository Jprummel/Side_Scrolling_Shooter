using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAim : MonoBehaviour
{
    [SerializeField]private GameObject _player;
    [SerializeField]private GameObject[] _objectsToAim;
    private Vector3 _playerPos;
    private Vector3 _difference;
    private float _angle;
    private SpriteRenderer _bodySprite;

    void Awake()
    {
        _bodySprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        LookAtTarget();
    }

    void LookAtTarget()
    {
        _playerPos = _player.transform.position;
        _difference = this.transform.position - _playerPos;
        Debug.Log(_difference.x);
        _angle = Mathf.Atan2(_playerPos.y, _playerPos.x) * Mathf.Rad2Deg;

        for (int i = 0; i < _objectsToAim.Length; i++)
        {
                _objectsToAim[i].transform.rotation = Quaternion.Euler(0, 0, Mathf.Clamp(_angle, -180, 180));

                if (_difference.x < 0)
                {
                    FlipSprite(true);
                }
                else if (_difference.x > 0)
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
        }else
        {
            bodyRotation.y = 0;
        }

    }
}