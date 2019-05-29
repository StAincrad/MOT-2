using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeDamage : MonoBehaviour
{
    public string playerTag;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(playerTag))
        {
            collision.GetComponent<PlayerDead>().OnDead();
            Destroy(gameObject);
        }
    }

}
