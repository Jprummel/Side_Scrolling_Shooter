using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLeveling : MonoBehaviour {

    private int _xpAfterLevelUp;
    public int XPAfterLevelUp
    {
        get { return _xpAfterLevelUp; }
    }

    public void LevelUp()
    {
        GameInformation.CurrentXP -= GameInformation.RequiredXP;
        _xpAfterLevelUp = GameInformation.CurrentXP;
        GameInformation.PlayerLevel++;
        DetermineRequiredXP();
    }

    void DetermineRequiredXP()
    {
        int temp = GameInformation.PlayerLevel * 1000 + 250;
        GameInformation.RequiredXP = temp;
    }
}
