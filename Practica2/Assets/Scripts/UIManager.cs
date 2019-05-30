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

    public void FinishGame(bool playerWins)
    {
        if (FinishPanel == null)
        {
            GameManager.instance.ChangeScene("10_Menu");
            return;
        }

        FinishPanel.SetActive(true);

        if (playerWins )
            FinishText.text = "HAS GANADO!!!";
        else
            FinishText.text = "HAS PERDIDO!!";

    }


}
