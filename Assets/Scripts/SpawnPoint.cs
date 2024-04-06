using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Transform[] _targetPoints;

    public void SpawnEnemy()
    {
        _enemy = Instantiate(_enemy, transform.position, Quaternion.identity);
        _enemy.SetTargetPoints(_targetPoints);
    }
}

