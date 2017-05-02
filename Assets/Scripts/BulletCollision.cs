using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BulletCollision : MonoBehaviour {

    [SerializeField]private int _damage;

    void OnTriggerEnter2D(Collider2D coll)
    {       //if player hits enemy                                               //if enemy hits player                                               //if bullet hits obstacle
        if (coll.gameObject.tag == Tags.PLAYER & this.tag == Tags.ENEMYBULLET || coll.gameObject.tag == Tags.ENEMY & this.tag == Tags.PLAYERBULLET || coll.gameObject.tag == Tags.OBSTACLE)
        {
            if(coll.gameObject.tag != Tags.OBSTACLE)
            {
                ExecuteEvents.Execute<IDamageable>(coll.gameObject, null, (x, y) => x.TakeDamage(_damage));
            }
            Destroy(this.gameObject);
        }
    }
}
