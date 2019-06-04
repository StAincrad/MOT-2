using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickMe : MonoBehaviour
{
    public int points;

    /// <summary>
    /// Manage collision between player and barel giving points to player if player collides against barel
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.instance.AddPoints(points);
            Destroy(gameObject);
        }
    }

}
