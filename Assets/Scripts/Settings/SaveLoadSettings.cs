﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveLoadSettings : MonoBehaviour {

    public void SaveSettings()
    {
        //Save the settings
        Debug.Log("Sayuved");
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/SavedSettingsSlot.dat");

        SettingsData settingsData = new SettingsData();
        settingsData.ResolutionWidth = SettingsInformation.ResolutionWidth;
        settingsData.ResoltuionHeight = SettingsInformation.ResoltuionHeight;
        settingsData.IsFullScreen = SettingsInformation.IsFullScreen;
        bf.Serialize(file, settingsData);
        file.Close();
    }

    public void LoadSettings()
    {
        if (File.Exists(Application.persistentDataPath + "/SaveDataSlot.dat"))
        {
            Debug.Log("Loaded file");
            //If there is a save file of the settings, load the settings
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/SavedSettingsSlot.dat", FileMode.Open);

            SettingsData settingsData               = (SettingsData)bf.Deserialize(file);

            SettingsInformation.ResolutionWidth = settingsData.ResolutionWidth;
            SettingsInformation.ResoltuionHeight = settingsData.ResoltuionHeight;
            SettingsInformation.IsFullScreen = settingsData.IsFullScreen;
            file.Close();
        }
        else
        {
            //If there is no save file of the settings set these as the default
            Debug.Log("Loaded Defaults");
            SettingsInformation.ResolutionWidth = 1920;
            SettingsInformation.ResoltuionHeight = 1080;
            SettingsInformation.IsFullScreen = true;
        }
    }
    
}
[System.Serializable]
public class SettingsData
{
    public int ResolutionWidth;
    public int ResoltuionHeight;
    public bool IsFullScreen;
}