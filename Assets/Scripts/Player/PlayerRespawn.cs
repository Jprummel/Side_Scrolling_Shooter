using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour {

    //private Transform _respawnPoint;
    public Transform RespawnPoint { get; set; }

    public void Respawn()
    {
        this.transform.position = RespawnPoint.position;
    }
}
