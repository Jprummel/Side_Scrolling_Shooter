using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInRadius : MonoBehaviour {

    private bool _playerInSight;

    // Update is called once per frame
    void Update () {
        Debug.Log(_playerInSight);
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

    public bool _PlayerInSight
    {
        get { return _playerInSight; }
        set { _playerInSight = value; }
    }
}
