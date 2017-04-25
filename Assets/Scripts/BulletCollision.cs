using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BulletCollision : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag != this.tag)
        {
            if(coll.gameObject.tag != Tags.OBSTACLE)
            {
                
            }
            Destroy(this.gameObject);
        }
    }
}
