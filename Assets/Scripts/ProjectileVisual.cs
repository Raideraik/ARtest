using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileVisual : MonoBehaviour
{
    [SerializeField] private MeshRenderer[] _meshRenderers;
    [SerializeField] private Material[] _materials;

    private void Start()
    {

        for (int i = 0; i < _meshRenderers.Length; i++)
        {
            _meshRenderers[i].material = _materials[Random.Range(0, _materials.Length)];
        }
    }


}
