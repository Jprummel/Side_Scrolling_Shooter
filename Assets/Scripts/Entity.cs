using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour {

    [SerializeField]private float _movementSpeed;
    [SerializeField]private int _maxHealth;
    [SerializeField]private int _baseDamage;
    private int _currentDamage;
    private int _currentHealth;

    public float MovementSpeed
    {
        get { return _movementSpeed; }
        set { _movementSpeed = value; }
    }

    public int Health
    {
        get { return _maxHealth; }
        set { _maxHealth = value; }
    }

    public int BaseDamage
    {
        get { return _baseDamage; }
        set { _baseDamage = value; }
    }

    public int CurrentDamage
    {
        get { return _currentDamage; }
        set { _currentDamage = value; }
    }

    public int CurrentHealth
    {
        get { return _currentHealth; }
        set { _currentHealth = value; }
    }
}
