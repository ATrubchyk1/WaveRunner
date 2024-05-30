using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class HorizontalMovingObstacle : MonoBehaviour
{
    [SerializeField] private float _oneWayDuration = 2f;
    [SerializeField] private Vector3 _leftBorder = new Vector3(-3, 0, 0);
    [SerializeField] private Vector3 _rightBorder = new Vector3(3, 0, 0);
    private float _currentTime;
    
    private void Update()
    {
        _currentTime += Time.deltaTime;
        var progress = Mathf.PingPong(_currentTime, _oneWayDuration) / _oneWayDuration;
        transform.position = Vector3.Lerp(_leftBorder, _rightBorder, progress);
    }
}
