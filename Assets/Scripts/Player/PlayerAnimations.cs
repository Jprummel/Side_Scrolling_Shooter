using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;

public class PlayerAnimations : MonoBehaviour {

    private SkeletonAnimation _spineAnimation;
    private PlayerMovement _playerMovement;

    [SerializeField]private List<GameObject> _animationObjects = new List<GameObject>();

    void Start()
    {
        _playerMovement = GetComponent<PlayerMovement>();
        _spineAnimation = GetComponent<SkeletonAnimation>();
    }

    void Update () {
        MoveAnimations();
	}

    void MoveAnimations()
    {
        if (_playerMovement.IsMoving)
        {
            for (int i = 0; i < _animationObjects.Count; i++)
            {
                _animationObjects[i].GetComponent<SkeletonAnimation>().AnimationName = "Run";
            }
        }
        else
        {
            for (int i = 0; i < _animationObjects.Count; i++)
            {
                _animationObjects[i].GetComponent<SkeletonAnimation>().AnimationName = "Idle";
            }
        }
    }

    void ShootAnimations()
    {

    }
}
