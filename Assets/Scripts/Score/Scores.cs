using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scores : MonoBehaviour {

    [SerializeField]private int _level;
    private int _score;
    private int _highscore;

	void Start () {
        switch (_level)
        {
            case 1:
                _highscore = GameInformation.HighscoreLevel1;
                break;
            case 2:
                _highscore = GameInformation.HighscoreLevel2;
                break;
        }

	}

    public void AddScore(int scoreToGive, int multiplier)
    {
        _score += scoreToGive * multiplier;
    }

    public void CheckForNewHighscore()
    {
        if (_score > _highscore)
        {
            _highscore = _score;
            switch (_level)
            {
                case 1:
                    GameInformation.HighscoreLevel1 = _highscore;
                    break;
                case 2:
                    GameInformation.HighscoreLevel2 = _highscore;
                    break;
            }
        }
    }
}
