using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    [SerializeField] private Button _pauseButton;
    [SerializeField] private Button _continueButton;
    [SerializeField] private Button _exitButton;
    [SerializeField] private GameObject _pauseMenu;

    private void OnEnable()
    {
        _pauseButton.onClick.AddListener(SetPause);
        _continueButton.onClick.AddListener(Continue);
        _exitButton.onClick.AddListener(Exit);
    }

    private void OnDisable()
    {
        _pauseButton.onClick.RemoveListener(SetPause);
        _continueButton.onClick.RemoveListener(Continue);
        _exitButton.onClick.RemoveListener(Exit);
    }

    private void SetPause()
    {
        Time.timeScale = 0;
        _pauseMenu.SetActive(true);
    }

    private void Continue()
    {
        Time.timeScale = 1;
        _pauseMenu.SetActive(false);
    }

    private void Exit()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
