using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour {

    private Transform _checkpoint;
    public Transform Checkpoint;

    public void Respawn()
    {
        this.transform.position = Checkpoint.position;
    }
}
