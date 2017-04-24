using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAim : MonoBehaviour
{

    [SerializeField]
    private GameObject _player;

    private SpriteRenderer _sprite;
    private SpriteRenderer _bodySprite;
    private float _yRotation;
    private float min = /*-30*/-180;
    private float max = /*55*/180;

    // Use this for initialization
    void Awake()
    {
        _sprite = GetComponentInChildren<SpriteRenderer>();
        _bodySprite = GetComponentInParent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        LookAtTarget();
    }

    void LookAtTarget()
    {
        Vector3 playerPos = _player.transform.position;
        float angle = Mathf.Atan2(playerPos.y, playerPos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, _yRotation, Mathf.Clamp(angle, min, max));
        if (angle > 90 || angle < -90)
        {
            /*min = 135f;
            max = 200f;*/
            FlipSprite(true);
        }
        else
        {
            FlipSprite(false);
            /*min = -30f;
            max = 55f;*/
        }
    }

    void FlipSprite(bool dir)
    {
        _sprite.flipX = dir;
        _sprite.flipY = dir;
        _bodySprite.flipX = dir;
    }
}