using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

    private PlayerRespawn _playerRespawn;

    void Awake()
    {
        _playerRespawn = GameObject.FindGameObjectWithTag(Tags.PLAYER).GetComponent<PlayerRespawn>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == Tags.PLAYER)
        {
            if (_playerRespawn.RespawnPoint != null)
            {
                _playerRespawn.RespawnPoint.gameObject.SetActive(false); //Sets the previous checkpoint inactive so it cant be reactivated
            }
            _playerRespawn.RespawnPoint = this.transform; //Sets the new checpoint
        }
    }
}
