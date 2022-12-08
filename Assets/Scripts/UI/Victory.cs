using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    [SerializeField] private GameObject _victoryScreen;
    [SerializeField] private Score _score;

    private void OnEnable()
    {
        _score.OnVictoryScoreAchieved += Score_OnVictoryScoreAchieved;
    }

    private void OnDisable()
    {
        _score.OnVictoryScoreAchieved -= Score_OnVictoryScoreAchieved;
    }

    private void Score_OnVictoryScoreAchieved(object sender, EventArgs e)
    {
        Time.timeScale = 0;
        _victoryScreen.SetActive(true);
    }
}
