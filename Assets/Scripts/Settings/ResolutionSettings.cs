using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResolutionSettings : MonoBehaviour {

    [SerializeField]private Dropdown _dropdown;
    private bool _isFullScreen;
    private int _resolutionWidth;
    private int _resolutionHeight;

    public void ChangeResolution()
    {
        switch(_dropdown.value){
            
            case 0:
                _resolutionWidth = 1024;
                _resolutionHeight = 768;                
                break;
            case 1:
                _resolutionWidth = 1280;
                _resolutionHeight = 720; 
                break;
            case 2:
                _resolutionWidth = 1366;
                _resolutionHeight = 768;
                break;
            case 3:
                _resolutionWidth = 1600;
                _resolutionHeight = 900;
                break;
            case 4:
                _resolutionWidth = 1920;
                _resolutionHeight = 1080;
                break;
        }
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
