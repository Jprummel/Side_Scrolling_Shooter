using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour {

    [SerializeField]private Image _fillBarImage;
    private FillImage _fillImage;

	void Awake () {
        _fillImage = GetComponent<FillImage>();
	}
	
	void Update () {
		
	}

    void UpdateEnergyBar()
    {
        _fillImage.Fill(_fillBarImage,1,1,1);
    }
}
