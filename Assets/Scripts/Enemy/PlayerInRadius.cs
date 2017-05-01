using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInRadius : MonoBehaviour {

    private bool _playerInSight;

    [SerializeField]
    private EnemyMovement _movement;

    [SerializeField]
    private EnemyAim _aim;

    [SerializeField]
    private EnemyAttack _attack;

    // Update is called once per frame
    void Update () {
        Debug.Log(_playerInSight);
        SetScripts();
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            _playerInSight = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            _playerInSight = false;
        }
    }

    private void SetScripts() {
        if (_playerInSight)
        {
            _movement.enabled = false;

            _attack.enabled = true;
        }
        else if (!_playerInSight)
        {
            _movement.enabled = true;

            _attack.enabled = false;
        }
    }
}
