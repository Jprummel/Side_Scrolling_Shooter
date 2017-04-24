using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

    [SerializeField]private GameObject _shootPoint;

    [SerializeField]private GameObject _bullet;

    private Entity _enemyEntity;

    [SerializeField]private float _waitForNextBullet;

    private float _reloadTime = 10;

    [SerializeField]private float timeLeft = 3.0f;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            StartCoroutine(Shoot());
            timeLeft = _reloadTime;
        }
    }


    IEnumerator Shoot()
    {
        Instantiate(_bullet, _shootPoint.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(_waitForNextBullet);
    }
}
