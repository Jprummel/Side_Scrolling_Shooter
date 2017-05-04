using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotion : MonoBehaviour 
{
    public void SlowMo()
    {
        Time.timeScale = Mathf.Lerp(1,0.5f,1);
    }
}
