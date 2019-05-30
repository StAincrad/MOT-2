using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public int playerPoints { get; private set; }
    public int playerLives { get; private set; }
    private UIManager uIManager;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        playerLives = 3;
    }

    /// <summary>
    /// Add points to player
    /// </summary>
    /// <param name="amount">Amount of points to add</param>
    public void AddPoints(int amount)
    {
        playerPoints += amount;
        uIManager.UpdateScore(playerPoints);
    }

    /// <summary>
    /// Subtract one life to player and check if the player is still alive
    /// </summary>
    /// <returns>True if player is alive, false if player is dead</returns>
    public bool PlayerLoseLife()
    {
        playerLives--;
        print("Lives :"+playerLives);
        uIManager.LifeLost();
        return playerLives <= 0;
    }
    /// <summary>
    /// Pass the reference of UIManager to gameManager
    /// </summary>
    /// <param name="currUIManager"></param>
    public void PassUIManagerReference(UIManager currUIManager)
    {
        uIManager = currUIManager;
    }
}
