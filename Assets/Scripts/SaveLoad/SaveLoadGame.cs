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

        saveData.PlayerLevel        = SaveInformation.PlayerLevel;
        saveData.currentXP          = SaveInformation.CurrentXP;
        saveData.requiredXP         = SaveInformation.RequiredXP;
        saveData.UnlockedStage      = SaveInformation.UnlockedStage;

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

            SaveInformation.PlayerLevel     = saveData.PlayerLevel;
            SaveInformation.CurrentXP       = saveData.currentXP;
            SaveInformation.RequiredXP      = saveData.requiredXP;
            SaveInformation.UnlockedStage   = saveData.UnlockedStage;

            file.Close();
        }
    }
}

public class SaveData
{
    public int PlayerLevel;
    public int currentXP;
    public int requiredXP;
    public int UnlockedStage;
}
