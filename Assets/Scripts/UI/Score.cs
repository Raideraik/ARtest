using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public EventHandler OnVictoryScoreAchieved;

    [SerializeField] private Player _player;
    [SerializeField] private Slider _scoreSlider;

    [SerializeField] private int _victoryScore = 5;

    private void Start()
    {
        _scoreSlider.maxValue = _victoryScore;
    }
    private void OnEnable()
    {
        _player.ScoreAdded += OnScoreAdded;
    }

    private void OnDisable()
    {
        _player.ScoreAdded -= OnScoreAdded;

    }

    private void OnScoreAdded(int score)
    {
        if (_victoryScore == score)
        {
            _scoreSlider.value = score;
            OnVictoryScoreAchieved?.Invoke(this, EventArgs.Empty);
        }
        else
            _scoreSlider.value = score;
    }
}
