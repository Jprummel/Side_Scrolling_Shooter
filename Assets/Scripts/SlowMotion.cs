using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotion : MonoBehaviour 
{
    private float _slowMoTimer;
    private bool _startSlowMotion;
    private bool _stopSlowMotion;
    private bool _isSlowMo;

    void Update()
    {
        if (_startSlowMotion)
        {
            _slowMoTimer += Time.fixedDeltaTime;
            Time.timeScale = Mathf.Lerp(1, 0.5f, _slowMoTimer * 2);
        }
        else if(_stopSlowMotion)
        {
            _slowMoTimer -= Time.fixedDeltaTime;
            Time.timeScale = Mathf.Lerp(0.5f, 1, _slowMoTimer * 2);
        }
    }

    public IEnumerator SlowMo(float waitTime)
    {
        _startSlowMotion = true;
        yield return new WaitForSeconds(waitTime);
        _slowMoTimer = 0;
        _stopSlowMotion = true;
    }
}
