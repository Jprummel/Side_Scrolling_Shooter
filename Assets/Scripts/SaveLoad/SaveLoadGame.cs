using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveLoadGame : MonoBehaviour {

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void SaveGameData()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/SaveDataSlot.dat");

        SaveData saveData = new SaveData();

        saveData.PlayerLevel        = GameInformation.PlayerLevel;
        saveData.currentXP          = GameInformation.CurrentXP;
        saveData.requiredXP         = GameInformation.RequiredXP;
        saveData.UnlockedStage      = GameInformation.UnlockedStage;

        saveData.HighscoreLevel1 = GameInformation.HighscoreLevel1;
        saveData.HighscoreLevel2 = GameInformation.HighscoreLevel2;

        bf.Serialize(file, saveData);
        file.Close();
    }

    public void LoadGameData()
    {
        if (File.Exists(Application.persistentDataPath + "/SaveDataSlot.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/SaveDataSlot.dat", FileMode.Open);

            SaveData saveData               = (SaveData)bf.Deserialize(file);

            GameInformation.PlayerLevel     = saveData.PlayerLevel;
            GameInformation.CurrentXP       = saveData.currentXP;
            GameInformation.RequiredXP      = saveData.requiredXP;
            GameInformation.UnlockedStage   = saveData.UnlockedStage;

            GameInformation.HighscoreLevel1 = saveData.HighscoreLevel1;
            GameInformation.HighscoreLevel2 = saveData.HighscoreLevel2;

            file.Close();
        }
    }
}

public class SaveData
{
    //Player progression
    public int PlayerLevel;
    public int currentXP;
    public int requiredXP;
    public int UnlockedStage;

    //Highscores
    public int HighscoreLevel1;
    public int HighscoreLevel2;
}
