using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAim : MonoBehaviour
{
    [SerializeField]private Transform _player;
    [SerializeField]private List<Transform> _objectsToAim = new List<Transform>();
    private Targeting _targeting;
    private Vector3 _playerPos;
    private Vector3 _difference;
    private float _angle;
    private SpriteRenderer _bodySprite;

    void Awake()
    {
        _targeting = GetComponent<Targeting>();
        _bodySprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        _targeting.LookAtTarget(_player, _objectsToAim);
        //LookAtTarget();
    }

    /*void LookAtTarget()
    {
        _playerPos = _player.transform.position;
        _difference = this.transform.position - _playerPos;
        _angle = Mathf.Atan2(_playerPos.y, _playerPos.x) * Mathf.Rad2Deg;

        for (int i = 0; i < _objectsToAim.Count; i++)
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

        for (int i = 0; i < _objectsToAim.Count; i++)
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

    }*/
}