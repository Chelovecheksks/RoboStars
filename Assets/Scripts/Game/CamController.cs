using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    private Transform _target;

    [SerializeField] private Vector3 _offset;

    public static CamController instance;

    [SerializeField] private float _smooth = 1f;

    private Vector3 _speed;
    void Awake()
    {
        instance = this;
    }

    void LateUpdate()
    {
        Work();
    }

    private void Work()
    {
        if (_target == null)
        {
            return;
        }
        
        Vector3 _newPosition = Vector3.SmoothDamp(transform.position, _target.position + _offset, ref _speed, _smooth);
        transform.position = _newPosition;
    }

    public void SetTarget(Transform target)
    {
        _target = target;
    }
}
