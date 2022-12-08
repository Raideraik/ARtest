using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform _deathEffect;
    [SerializeField] private GameObject _enemyParent;
    [SerializeField] private float _deathTime;

    public event UnityAction<Enemy> Dying;

    public void Die()
    {
        Dying?.Invoke(this);
        Instantiate(_deathEffect, transform.position, Quaternion.identity);
        Destroy(_enemyParent);
    }

}
