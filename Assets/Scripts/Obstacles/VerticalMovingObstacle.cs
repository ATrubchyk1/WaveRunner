using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovingObstacle : MonoBehaviour
{
    [SerializeField] private float _oneWayDurationTime = 1.5f;
    [SerializeField] private Vector3 _upPosition = new Vector3(0,3,0);
    [SerializeField] private Vector3 _downPosition = new Vector3(0,-3,0);
    private float _currentTime;
    
    private void Update()
    {
        _currentTime += Time.deltaTime;
        var progress = Mathf.PingPong(_currentTime, _oneWayDurationTime) / _oneWayDurationTime;
        transform.localPosition = Vector3.Lerp(_downPosition, _upPosition, progress);
    }
}
