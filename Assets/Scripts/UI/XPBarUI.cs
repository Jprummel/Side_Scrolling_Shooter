using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPBarUI : MonoBehaviour {

    [SerializeField]private Image _xpBarFiller;
    [SerializeField]private Text _xpValues;
    private FillImage _fillImage;

	void Start () {
        _fillImage = GetComponent<FillImage>();
        ShowXPValues();
	}

    public void FillBar(float startValue,float endValue)
    {
        _fillImage.Fill(_xpBarFiller, startValue, endValue, GameInformation.RequiredXP);
    }

    public void ShowXPValues()
    {
        _xpValues.text = GameInformation.CurrentXP + "/" + GameInformation.RequiredXP;
    }
}
