using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Victory : MonoBehaviour
{
    [SerializeField] private GameObject _victoryScreen;
    [SerializeField] private Score _score;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _clip;
    [SerializeField] private Button _exitButton;

    private void OnEnable()
    {
        _score.OnVictoryScoreAchieved += Score_OnVictoryScoreAchieved;
        _exitButton.onClick.AddListener(Exit);

    }

    private void OnDisable()
    {
        _score.OnVictoryScoreAchieved -= Score_OnVictoryScoreAchieved;
        _exitButton.onClick.RemoveListener(Exit);

    }

    private void Score_OnVictoryScoreAchieved(object sender, EventArgs e)
    {
        Time.timeScale = 0;
        _victoryScreen.SetActive(true);
        _audioSource.clip = _clip;
        _audioSource.Play();
    }
    private void Exit()
    {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync(0);
    }
}
