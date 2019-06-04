using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDead : MonoBehaviour
{
    public Transform spawnPoint;

    /// <summary>
    /// Move player position to spawnPoint position if player have lives or destroy him if he has no life left
    /// </summary>
    public void OnDead()
    {
        bool PlayerALive = GameManager.instance.PlayerLoseLife();

        if (PlayerALive)
            transform.position = spawnPoint.position;
        else
        {
            GameManager.instance.PlayerWinGame(false);
            Destroy(gameObject);
        }

    }
}
