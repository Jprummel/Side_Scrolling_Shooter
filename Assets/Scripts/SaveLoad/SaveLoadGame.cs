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
        saveData.PlayerMoveSpeed    = SaveInformation.PlayerMoveSpeed;
        saveData.PlayerMaxHealth    = SaveInformation.PlayerMaxHealth;
        saveData.PlayerDamage       = SaveInformation.PlayerDamage;
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

            SaveInformation.PlayerLevel = saveData.PlayerLevel;
            SaveInformation.PlayerMoveSpeed = saveData.PlayerMoveSpeed;
            SaveInformation.PlayerMaxHealth = saveData.PlayerMaxHealth;
            SaveInformation.PlayerDamage = saveData.PlayerDamage;
            SaveInformation.UnlockedStage = saveData.UnlockedStage;

            file.Close();
        }
    }
}

public class SaveData
{
    public int PlayerLevel;
    public float PlayerMoveSpeed;
    public int PlayerMaxHealth;
    public int PlayerDamage;
    public int UnlockedStage;
}
