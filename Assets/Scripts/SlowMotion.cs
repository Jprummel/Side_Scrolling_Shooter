using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotion : MonoBehaviour 
{
    private float _normalTimescale = 1f;
    private float _slowMoTimescale = 0.5f;

    private float _slowMoTimer;
    private bool _startSlowMotion;
    private bool _stopSlowMotion;
    private bool _isSlowMo;

    void Update()
    {
        if (_startSlowMotion)
        {
            _slowMoTimer += Time.fixedDeltaTime;
            Time.timeScale = Mathf.Lerp(_normalTimescale, _slowMoTimescale, _slowMoTimer * 2);
        }
        else if(_stopSlowMotion)
        {
            _slowMoTimer -= Time.fixedDeltaTime;
            Time.timeScale = Mathf.Lerp(_slowMoTimescale, _normalTimescale, _slowMoTimer * 2);
        }
    }

    public IEnumerator SlowMo(float waitTime)
    {
        if (!_isSlowMo)
        {
            _isSlowMo = true;
            _startSlowMotion = true;
            _slowMoTimer = 0;
            yield return new WaitForSeconds(waitTime);
            _startSlowMotion = false;

            _stopSlowMotion = true;
            yield return new WaitForSeconds(waitTime);
            _stopSlowMotion = false;
            _isSlowMo = false;
        }
    }
}
