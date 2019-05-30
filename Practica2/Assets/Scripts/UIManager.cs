using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoringText;
    public Image[] lives;

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

    public void LifeLost()
    {
        lives[GameManager.instance.playerLives].enabled = false;
    }


}
