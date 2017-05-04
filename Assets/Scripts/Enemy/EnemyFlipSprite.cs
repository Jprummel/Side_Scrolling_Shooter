using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFlipSprite : MonoBehaviour {

    [SerializeField]private EnemyMovement _enemyMovement;

    [SerializeField]private float _enemySize;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        FlipSprite();
	}


    private void FlipSprite()
    {
        if (_enemyMovement._enemySwitch == true)
        {
            transform.rotation = Quaternion.Euler(0, 180, transform.rotation.y);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, transform.rotation.y);
        }
    }
}
