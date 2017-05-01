using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreDisplay : MonoBehaviour {

    [SerializeField]private int _level;
    [SerializeField]private Text _highscoreDisplay;
    private int _highscore;

	void Awake () {
        switch (_level)
        {
            case 1:
                _highscore = GameInformation.HighscoreLevel1;
                break;
            case 2:
                _highscore = GameInformation.HighscoreLevel2;
                break;
        }
        _highscoreDisplay.text = _highscore.ToString();
	}
}
