using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            print("A Game Manager has been created");
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
            print("A copy of Game Manager has been destroyed");
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

        print("Added points: " + amount);
        print("Total Points: " + playerPoints);

       if (uIManager != null)
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

        if (uIManager != null)
            uIManager.LifeLost();

        return playerLives > 0;
    }
    /// <summary>
    /// Pass the reference of UIManager to gameManager
    /// </summary>
    /// <param name="currUIManager"></param>
    public void PassUIManagerReference(UIManager currUIManager)
    {
        uIManager = currUIManager;
    }
    /// <summary>
    /// Change scene
    /// </summary>
    /// <param name="sceneName">The name of the scene to change up</param>
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void PlayerWinGame(bool gameStatus)
    {
        playerLives = 3;
        if (uIManager != null) uIManager.FinishGame(gameStatus);
    }
}
