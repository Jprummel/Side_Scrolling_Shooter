using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    private ScreenShake _screenShake;
    private Knockback _knockback;
    private ParticleSystem _muzzleFlash;

    [SerializeField]private GameObject _bullet;
    [SerializeField]private float _reloadTime;
    private float _reloadTimer;
    private float _spreadTimer;
    private float _spread;

    private bool _reload;

	void Start () {
        _screenShake = Camera.main.GetComponent<ScreenShake>();
        _knockback = transform.root.GetComponent<Knockback>();
        _muzzleFlash = GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
        if (_reload)
        {
            _reloadTimer -= Time.deltaTime;
        }
	}

    public void Shoot()
    {
        if(_reloadTimer <= 0)
        {
            CreateBullet();
            AddSpread();
            GunFX();
            //increase spread for each bullet shot in the last x seconds with x min/max value.

            _reloadTimer = _reloadTime;
            _reload = true;
        }
    }

    void CreateBullet(float? yOffset = 0)
    {
        GameObject bullet = Instantiate(_bullet);
        bullet.transform.position = transform.position;

        float randomOffset = Random.Range(-yOffset.Value, yOffset.Value);

        bullet.transform.rotation = transform.rotation;
        bullet.tag = Tags.PLAYERBULLET;
        bullet.layer = LayerMask.NameToLayer("PlayerProjectile");
    }

    void GunFX()
    {
        _muzzleFlash.Emit(1);
        _screenShake.Shake(0.1f, 0.1f);
        _knockback.AddKnockback(10f, -transform.root.right);
    }

    void AddSpread()
    {
        _spread += 1;
        //timer if x seconds passed and no shot was fired, reset spread value
    }
}
