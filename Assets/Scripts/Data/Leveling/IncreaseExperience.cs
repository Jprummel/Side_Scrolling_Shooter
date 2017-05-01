using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseExperience : MonoBehaviour {
    
    private PlayerLeveling _leveling = new PlayerLeveling();
    private XPBarUI _xpUI;
    private int _xpBeforeAdding;
    private int _xpAfterAdding;

    void Awake()
    {
        _xpUI = GameObject.FindGameObjectWithTag(Tags.XPBAR).GetComponent<XPBarUI>();
    }

    public void AddExperience(int xpToGive)
    {
        StartCoroutine(AddExperienceRoutine(xpToGive)); 
    }

    IEnumerator AddExperienceRoutine(int xpToGive)
    {
        _xpBeforeAdding = GameInformation.CurrentXP;
        GameInformation.CurrentXP += xpToGive;
        _xpAfterAdding = GameInformation.CurrentXP;
        _xpUI.FillBar(_xpBeforeAdding, _xpAfterAdding);
        _xpUI.ShowXPValues();
        CheckForLevelUp();
        yield return null;
    }

    void CheckForLevelUp()
    {
        if (GameInformation.CurrentXP >= GameInformation.RequiredXP)
        {
            Debug.Log("lvl up");
            _leveling.LevelUp();
            _xpUI.ShowXPValues();
            _xpUI.FillBar(_xpBeforeAdding,_leveling.XPAfterLevelUp);
        }
    }
}
