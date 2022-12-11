using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioSettings : MonoBehaviour
{
    [SerializeField] private Button _musicButton;
    [SerializeField] private Button _effectButton;
    [SerializeField] private AudioMixer _audioMixer;

    private void OnEnable()
    {
        _musicButton.onClick.AddListener(SetMusic);
        _effectButton.onClick.AddListener(SetEffects);
    }

    private void OnDisable()
    {
        _musicButton.onClick.RemoveListener(SetMusic);
        _effectButton.onClick.RemoveListener(SetEffects);
    }

    private void SetMusic()
    {
        float minSound = -80f;
        float maxSound = -12f;
        _audioMixer.GetFloat("Music", out float volume);
        if (volume > minSound)
        {
            _audioMixer.SetFloat("Music", minSound);
        }
        else
        {
            _audioMixer.SetFloat("Music", maxSound);
        }
    }
    private void SetEffects()
    {
        float minSound = -80f;
        float maxSound = -15f;
        _audioMixer.GetFloat("Effects", out float volume);
        if (volume > minSound)
        {
            _audioMixer.SetFloat("Effects", minSound);
        }
        else
        {
            _audioMixer.SetFloat("Effects", maxSound);
        }
    }
}
