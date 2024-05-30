using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ScaleChangingObstacle : MonoBehaviour
{
    [SerializeField] private Vector3 _scale = new Vector3(3,3,3);
    [SerializeField] private float _oneWayDurationTime = 1.5f;
    private float _currentTime;
    private Vector3 _startPosition;

    private void Start()
    {
        _startPosition = transform.localScale;
    }

    private void Update()
    {
        _currentTime += Time.deltaTime;
        var progress = Mathf.PingPong(_currentTime, _oneWayDurationTime) / _oneWayDurationTime;
        transform.localScale = Vector3.Lerp(_startPosition, _scale, progress);
    }
}
