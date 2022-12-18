using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private Bullet _bulletPrefab;
    [SerializeField] private Animator _animator;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip[] _audioShoots;
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                _audioSource.clip = _audioShoots[Random.Range(0, _audioShoots.Length)];
                _audioSource.Play();
                _animator.SetTrigger("Fire");
                Instantiate(_bulletPrefab, _shootPoint);
            }
        }
        else if (Input.GetMouseButtonDown(0))
        {
            _audioSource.clip = _audioShoots[Random.Range(0, _audioShoots.Length)];

            _audioSource.Play();

            _animator.SetTrigger("Fire");

            Instantiate(_bulletPrefab, _shootPoint);
        }
    }
}
