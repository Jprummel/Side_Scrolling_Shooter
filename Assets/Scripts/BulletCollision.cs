using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BulletCollision : MonoBehaviour {

    [SerializeField]private float _damage;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag != this.tag)
        {
            if(coll.gameObject.tag != Tags.OBSTACLE)
            {
                ExecuteEvents.Execute<IDamageable>(coll.gameObject, null, (x, y) => x.TakeDamage(_damage));
            }
            Destroy(this.gameObject);
        }
    }
}
