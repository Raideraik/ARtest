using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private Bullet _bulletPrefab;
    [SerializeField] protected Animator _animator;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                _animator.SetTrigger("Fire");
                Instantiate(_bulletPrefab, _shootPoint);
            }
        }
        else if (Input.GetMouseButtonDown(0))
        {
            _animator.SetTrigger("Fire");

            Instantiate(_bulletPrefab, _shootPoint);
        }
    }
}
