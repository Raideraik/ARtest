using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button _startButton;
    [SerializeField] private Button _exitButton;
    [SerializeField] private string _levelName;

    private void OnEnable()
    {
        _startButton.onClick.AddListener(StartGame);
        _exitButton.onClick.AddListener(Exit);
    }

    private void OnDisable()
    {
        _startButton.onClick.RemoveListener(StartGame);
        _exitButton.onClick.RemoveListener(Exit);
    }

    private void StartGame()
    {
        SceneManager.LoadSceneAsync(_levelName);
    }

    private void Exit()
    {
        Application.Quit();
    }
}
