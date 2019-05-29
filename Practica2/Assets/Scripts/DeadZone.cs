using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    /// <summary>
    /// Call OnDead
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerDead>())
        {
            collision.GetComponent<PlayerDead>().OnDead();
        }
    }
}
