using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseExperience : MonoBehaviour {

    private PlayerLeveling _leveling = new PlayerLeveling();

    public void AddExperience(int xpToGive)
    {
        GameInformation.CurrentXP += xpToGive;
        CheckForLevelUp();
        
    }

    void CheckForLevelUp()
    {
        if (GameInformation.CurrentXP >= GameInformation.RequiredXP)
        {
            _leveling.LevelUp();
        }
    }
}
