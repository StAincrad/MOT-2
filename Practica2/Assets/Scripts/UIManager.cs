using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Image[] lives;
    public Text scoringText;
    public Text FinishText;
    public GameObject FinishPanel;

	void Start ()
    {
        GameManager.instance.PassUIManagerReference(gameObject.GetComponent<UIManager>());
        scoringText.text = "0";
	}
	
    /// <summary>
    /// Update score board in HUD
    /// </summary>
    /// <param name="points">Amount of score to update</param>
    public void UpdateScore(int points)
    {
        scoringText.text = points.ToString();
    }

    /// <summary>
    /// Disable a full life
    /// </summary>
    public void LifeLost()
    {
        lives[GameManager.instance.playerLives].enabled = false;
    }

    /// <summary>
    /// When finish the game change the scene if the current scene
    /// is '10_Game', but then it shows up a panel with the info.
    /// </summary>
    /// <param name="playerWins">
    /// Indicates if the player has won the game
    /// </param>
    public void FinishGame(bool playerWins)
    {
        if (FinishPanel == null)
        {
            GameManager.instance.ChangeScene("10_Menu");
            return;
        }

        FinishPanel.SetActive(true);

        if (playerWins) { 
            FinishText.text = "HAS GANADO!!!" + "\nPuntos: " + GameManager.instance.playerPoints;}
        else
            FinishText.text = "HAS PERDIDO!!";

    }


}
