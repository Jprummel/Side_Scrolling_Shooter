﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameInformation : MonoBehaviour {
    
    //Player progression
    public static bool IsNewSave = true;
    public static int PlayerLevel;
    public static int CurrentXP;
    public static int RequiredXP;
    public static int UnlockedStage;

    //Level highscores
    public static int HighscoreLevel1;
    public static int HighscoreLevel2;

    void Awake()
    {
        if (IsNewSave)
        {
            PlayerLevel = 1;
            RequiredXP = 1000;
            IsNewSave = false;
        }
    }
}
