using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickMe : MonoBehaviour
{
    public string playerTag;
    public int points;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(playerTag))
        {
            GameManager.instance.AddPoints(points);
            Destroy(gameObject);
        }
    }

}
