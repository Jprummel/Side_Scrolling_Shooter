using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

    public void ChangeState(SpriteRenderer sprite, Color beginColor, Color endColor)
    {
        sprite.color = Color.Lerp(beginColor, endColor, Time.deltaTime);
    }
}
