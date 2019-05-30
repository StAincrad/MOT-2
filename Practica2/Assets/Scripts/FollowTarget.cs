using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public float distanceY;
    public Transform target;

	void Update ()
    {
        transform.position = new Vector3(target.position.x,target.position.y+distanceY,-10f);
	}
}
