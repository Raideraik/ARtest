using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Player _target;

    private Vector3 _direction;

    private void Start()
    {
        _direction = ChooseRandomDirection();
    }

    private void Update()
    {
        transform.RotateAround(_target.transform.position, _direction, _speed * Time.deltaTime);
    }

    private Vector3 ChooseRandomDirection()
    {
        Vector3 direction = new Vector3();
        switch (Random.Range(0, 3))
        {
            case 0:
                direction = Vector3.up;
                break;
            case 1:
                direction = Vector3.down;
                break;
            case 2:
                direction = Vector3.left;
                break;
            case 3:
                direction = Vector3.right;
                break;
        }
        return direction;

    }
}
