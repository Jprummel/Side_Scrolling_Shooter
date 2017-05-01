using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour, IDamageable {

    [SerializeField]protected string _name;
    [SerializeField]protected float _jumpPower;
    [SerializeField]protected float _movementSpeed;
    [SerializeField]protected int _maxLives;
    [SerializeField]protected int _maxHealth;
    [SerializeField]protected int _baseDamage;
    protected SpriteRenderer _renderer;
    protected ChangeColor _change;
    private int _currentLives;
    private int _currentDamage;
    private int _currentHealth;

    public float JumpPower
    {
        get { return _jumpPower; }
        set { _jumpPower = value; }
    }

    public float MovementSpeed
    {
        get { return _movementSpeed; }
        set { _movementSpeed = value; }
    }

    public int MaxLives
    {
        get { return _maxLives; }
        set { _maxLives = value; }
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

    public SpriteRenderer Renderer
    {
        get { return _renderer; }
        set { _renderer = value; }
    }

    public int CurrentLives
    {
        get { return _currentLives; }
        set { _currentLives = value; }
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

    protected virtual void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _change = GetComponent<ChangeColor>();

        _currentLives = _maxLives;
        _currentHealth = _maxHealth;
    }

    public void TakeDamage(int damage)
    {
        _currentHealth -= damage;
        if(_currentHealth <= 0)
        {
            _currentLives -= 1;
            if(_currentLives <= 0)
            {
                //death animation
                Destroy(this.gameObject);
            }
        }
    }
}
