using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform target;
    private float offSet;

    private void Start()
    {
        offSet = transform.position.z - target.position.z ;
    }
    void Update ()
    {
        if (target!=null)
            transform.position = new Vector3(target.position.x, target.position.y + 1.5f, offSet);
    }
}
