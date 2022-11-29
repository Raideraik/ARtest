using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _scoreDisplay;
    [SerializeField] private GameObject _winDisplay;

    private int _victoryScore = 5;

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
        if (_victoryScore <= score)
        {
            _scoreDisplay.text = score.ToString();
            _winDisplay.SetActive(true);

        }
        else
            _scoreDisplay.text = score.ToString();
    }
}
