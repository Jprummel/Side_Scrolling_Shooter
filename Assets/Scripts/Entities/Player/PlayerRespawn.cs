using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour {

    public delegate void RespawnEvent();
    public static RespawnEvent respawnEvent;

    public Transform RespawnPoint { get; set; }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Respawn();
        }
    }

    public void Respawn()
    {
        if (respawnEvent != null)
        {
            respawnEvent();
        }
        this.transform.position = RespawnPoint.position;
    }
}
