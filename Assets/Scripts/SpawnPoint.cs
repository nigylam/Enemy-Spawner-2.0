using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Transform[] _targetPoints;
    

    public void SpawnEnemy()
    {
        Vector3 position = transform.position + Vector3.up;
        _enemy = Instantiate(_enemy, position, Quaternion.identity);
        _enemy.SetTargetPoints(_targetPoints);
    }
}

