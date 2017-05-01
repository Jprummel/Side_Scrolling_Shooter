using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillImage : MonoBehaviour {

    public void Fill(Image image, float currentValue, float finalValue,float maxValue)
    {
        image.fillAmount = Mathf.Lerp(currentValue, finalValue, 1) / maxValue;
    }
}
