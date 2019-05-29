using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDead : MonoBehaviour
{
    public Transform spawnPoint;

    /// <summary>
    /// Move player position to spawnPoint position
    /// </summary>
    public void OnDead()
    {
        transform.position = spawnPoint.position;
    }
}
