using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInRadius : MonoBehaviour {
    
    [SerializeField]private EnemyMovement _movement;
    [SerializeField]private EnemyAim _aim;
    [SerializeField]private EnemyAttack _attack;

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
        _movement.enabled   = false;
        _aim.enabled        = true;
        _attack.enabled     = true;
    }

    void DisableScripts()
    {
        //Disables enemy scripts
        _movement.enabled   = true;
        _aim.enabled        = false;
        _attack.enabled     = false;
    }
}
