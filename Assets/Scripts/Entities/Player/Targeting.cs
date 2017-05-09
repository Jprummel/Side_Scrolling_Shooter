using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targeting : MonoBehaviour {

    private BodyRotation _bodyRotation;

	void Awake () 
    {
        _bodyRotation = GetComponent<BodyRotation>();
	}

    public void LookAtTarget(Transform target, List<Transform> entitiesToAim)
    {
        for (int i = 0; i < entitiesToAim.Count; i++)
        {
            //Calculate difference between targets position and the entities that have to aim
            Vector3 _difference = target.position - entitiesToAim[i].position;
            _difference.Normalize();
            float rotationZ = Mathf.Atan2(_difference.y, _difference.x) * Mathf.Rad2Deg; //Calculate rotation float

            if (_difference.x < 0) // if the target is left of the entity , look left
            {
                _bodyRotation.Flipped = true;
            }
            else if (_difference.x > 0) // if the target is right of the entity look right
            {
                _bodyRotation.Flipped = false;
            }

            if (_bodyRotation.Flipped)
            {
                entitiesToAim[i].rotation = Quaternion.Euler(180, 0, -rotationZ);
            }
            else if (!_bodyRotation.Flipped)
            {
                entitiesToAim[i].rotation = Quaternion.Euler(0, 0, rotationZ);
            }
        }
    }
}
