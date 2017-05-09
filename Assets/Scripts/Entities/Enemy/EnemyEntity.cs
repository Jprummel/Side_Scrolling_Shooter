using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEntity : Entity {
    
    [SerializeField]private int _scoreToGive;
    private Scores _score;

    protected override void Awake()
    {
        base.Awake();
        //_score = GameObject.FindGameObjectWithTag("ScoreKeeper").GetComponent<Scores>();
    }

    void Death()
    {
        _score.AddScore(_scoreToGive,1);
    }
}
