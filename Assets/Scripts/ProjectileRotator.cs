using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileRotator : MonoBehaviour
{
    private void Update()
    {

        transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
    }
}
