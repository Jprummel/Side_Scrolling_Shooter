using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAim : MonoBehaviour
{
    [SerializeField]private Transform _player;
    [SerializeField]private List<Transform> _objectsToAim = new List<Transform>();
    private Targeting _targeting;

    void Awake()
    {
        _targeting = GetComponent<Targeting>();
    }

    void Update()
    {
        _targeting.LookAtTarget(_player, _objectsToAim);
    }
}