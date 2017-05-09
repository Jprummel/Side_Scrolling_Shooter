using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RespawningRoutine : MonoBehaviour {

    [SerializeField]private Image _fadeImage;
    [SerializeField]private float _respawnTime;
    private Fades _fades;

	void Awake () {
        _fades = GameObject.FindGameObjectWithTag(Tags.FADEROBJECT).GetComponent<Fades>();
        PlayerRespawn.respawnEvent += Respawn;
	}

    void Respawn()
    {
        StartCoroutine(RespawnRoutine());
    }

    IEnumerator RespawnRoutine()
    {
        //Play death animation
        //yield return new WaitForSeconds();
        StartCoroutine(_fades.FadeOut(_fadeImage, false, _respawnTime));
        yield return new WaitForSeconds(_respawnTime + 0.5f);
        StartCoroutine(_fades.FadeIn(_fadeImage));
        //yield return new WaitForSeconds();
        //play respawn animation
    }

    void OnDisable()
    {
        PlayerRespawn.respawnEvent -= Respawn;
    }
}
