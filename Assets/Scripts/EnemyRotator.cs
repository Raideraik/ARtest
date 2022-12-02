using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotator : MonoBehaviour
{
    [SerializeField] private Transform _targetPoint;
    [SerializeField] private float _speed;
    [SerializeField] private bool _isLookingAtTarget = true;

    private void Update()
    {
        if (_isLookingAtTarget)
            transform.LookAt(_targetPoint);

        if (Vector3.Distance(transform.position, _targetPoint.position) > 0.5f)
        {
            transform.position = Vector3.Lerp(transform.position, _targetPoint.position, Time.deltaTime * _speed);
        }
        // transform.position = _targetPoint.position * Time.deltaTime;
    }
}
