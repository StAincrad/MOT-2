using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    public string playerTag;
    /// <summary>
    /// Call OnDead
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(playerTag))
        {
            collision.GetComponent<PlayerDead>().OnDead();
        }
    }
}
