using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFlipSprite : MonoBehaviour {

    [SerializeField]private EnemyMovement _enemyMovement;

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
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
