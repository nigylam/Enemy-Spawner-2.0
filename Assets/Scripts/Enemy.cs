using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _closeDistanceToTarget = 0.5f;

    private Transform[] _targetPoints;
    private int _currentTarget = 0;

    private void Update()
    {
        Move();
    }

    public void SetTargetPoints(Transform[] targetPoints)
    {
        _targetPoints = targetPoints;
    }

    private void Move()
    {
        SetDirection();
        transform.position = Vector3.MoveTowards(transform.position, _targetPoints[_currentTarget].position, _speed * Time.deltaTime);
    }

    private void SetDirection()
    {
        float distanceToTarget = Vector3.Distance(transform.position, _targetPoints[_currentTarget].position);

        if (distanceToTarget <= _closeDistanceToTarget)
            _currentTarget = (_currentTarget + 1) % _targetPoints.Length;
    }
}
