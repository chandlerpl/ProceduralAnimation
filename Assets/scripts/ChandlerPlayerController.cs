using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChandlerPlayerController : MonoBehaviour
{
    public Transform leftTarget;
    public Transform rightTarget;

    public float stepSize = 1f;
    public float stepHeight = 0.2f;

    private Vector3 _currentLeftPos;
    private Vector3 _currentRightPos;

    private Vector3 _prevLeftPos;
    private Vector3 _prevRightPos;

    private Vector3 _nextLeftPos;
    private Vector3 _nextRightPos;

    void Start()
    {
        _nextLeftPos = _prevLeftPos = _currentLeftPos = leftTarget.position;
        _nextRightPos = _prevRightPos = _currentRightPos = rightTarget.position;

        _nextLeftPos = _prevLeftPos + (leftTarget.forward * stepSize);
    }

    void Update()
    {
        
    }
}
