using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using Random = UnityEngine.Random;

public class RotatingObstacle : MonoBehaviour
{
    [SerializeField] private Vector3 _rotationSpeed;
    private void Update()
    {
        transform.Rotate(_rotationSpeed * Time.deltaTime);
    }
}
