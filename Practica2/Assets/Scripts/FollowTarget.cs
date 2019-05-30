﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public float distanceY;
    public Transform target;

	void Update ()
    {
        if (target!=null)
            transform.position = new Vector3(target.position.x, target.position.y + distanceY, -10f);
    }
}
