using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolutionSettings : MonoBehaviour {

    private bool _isFullScreen;
    private int _resolutionWidth;
    private int _resolutionHeight;

	void Start () {
		
	}

    public void SetResolutionWidth(int width)
    {
        _resolutionWidth = width;
    }

    public void SetResolutionHeight(int height)
    {
        _resolutionHeight = height;
    }

    public void ChangeResolution()
    {
        Screen.SetResolution(_resolutionWidth, _resolutionHeight, _isFullScreen);
    }

    public void ToggleFullScreen()
    {
        if (_isFullScreen)
        {
            _isFullScreen = false;
        }
        else
        {
            _isFullScreen = true;
        }

        Screen.SetResolution(_resolutionWidth, _resolutionHeight, _isFullScreen);
    }
}
