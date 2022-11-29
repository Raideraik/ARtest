using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectDestroyer : MonoBehaviour
{
    [SerializeField] private int _destroyWaitTime;

    private void Start()
    {
        StartCoroutine(DestroyEffect());
    }

    private IEnumerator DestroyEffect()
    {
        yield return new WaitForSeconds(_destroyWaitTime);
        Destroy(gameObject);
    }
}
