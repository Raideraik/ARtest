using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollower : MonoBehaviour
{
    [SerializeField] private Transform _targetPoint;
    [SerializeField] private bool _isLookingAtTarget = true;

    private void Update()
    {
        if (_isLookingAtTarget)
            transform.LookAt(_targetPoint);

        transform.position = _targetPoint.position;
    }
}
