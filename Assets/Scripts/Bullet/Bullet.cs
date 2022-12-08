using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _timeAlive;

    private void Start()
    {
        StartCoroutine(BulletDestroy());
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Enemy enemy))
        {
            enemy.Die();
            Destroy(gameObject);
        }
    }

    private IEnumerator BulletDestroy()
    {
        yield return new WaitForSeconds(_timeAlive);
        Destroy(gameObject);

    }
}
