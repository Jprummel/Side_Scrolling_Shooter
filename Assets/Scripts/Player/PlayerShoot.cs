using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    [SerializeField]private GameObject _bullet;
    [SerializeField]private float _reloadTime;
    private float _timer;
    private bool _reload;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (_reload)
        {
            _timer -= Time.deltaTime;
        }
	}

    public void Shoot()
    {
        if(_timer <= 0)
        {
            GameObject bullet = Instantiate(_bullet);
            bullet.transform.position = transform.position;
            bullet.transform.rotation = transform.rotation;
            _timer = _reloadTime;
            _reload = true;
        }
    }
}
