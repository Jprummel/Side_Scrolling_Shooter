using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInRadius : MonoBehaviour {
    
    [SerializeField]private EnemyMovement _movement;
    [SerializeField]private EnemyAim _aim;
    [SerializeField]private EnemyAttack _attack;

    [SerializeField]private BodyRotation _bodyrotation;
    [SerializeField]private EnemyFlipSprite _movementFlip;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            EnableScripts(); //If player enters radius, enable aim and attack scripts & stop moving
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            DisableScripts();//If player leaves radius ,  disable aim and attack scripts & continue moving
        }
    }

    void EnableScripts()
    {
        //Enables enemy scripts
        _movementFlip.enabled = false;
        _movement.enabled   = false;
        _aim.enabled        = true;
        _attack.enabled     = true;
        _bodyrotation.enabled = true;

    }

    void DisableScripts()
    {
        //Disables enemy scripts
        _movement.enabled   = true;
        _movementFlip.enabled = true;
        _aim.enabled        = false;
        _attack.enabled     = false;
        _bodyrotation.enabled = false;
    }
}
