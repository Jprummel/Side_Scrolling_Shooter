﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShell : MonoBehaviour {

    private Collider2D _thisCollider;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == Tags.PLAYER)
        {
            Collider2D otherCollider = other.gameObject.GetComponent<Collider2D>();
            IgnoreCollisions(otherCollider);
        }
    }

    void IgnoreCollisions(Collider2D other)
    {
        Physics2D.IgnoreCollision(other, _thisCollider);
    }
}
