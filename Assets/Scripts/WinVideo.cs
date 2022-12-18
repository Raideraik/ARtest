using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class WinVideo : MonoBehaviour
{
    [SerializeField] private VideoPlayer _player;
    [SerializeField] private VideoClip _clip;
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
        _player.Play();

        _player.loopPointReached += EndReached;
    }

    private void EndReached(VideoPlayer vp)
    {
        _player.clip = _clip;
        _player.isLooping = true;
        _player.Play();
    }
}
