using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLeveling : MonoBehaviour {

    public void LevelUp()
    {
        if (GameInformation.CurrentXP > GameInformation.RequiredXP)
        {
            GameInformation.CurrentXP -= GameInformation.RequiredXP;

        }
        else
        {
            GameInformation.CurrentXP = 0;
        }

        GameInformation.PlayerLevel++;
        DetermineRequiredXP();
    }

    void DetermineRequiredXP()
    {
        int temp = GameInformation.PlayerLevel * 1000 + 250;
        GameInformation.RequiredXP = temp;
    }
}
