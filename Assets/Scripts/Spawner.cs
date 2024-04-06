using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _spawnPoints;
    [SerializeField] private float _spawnDelayTime = 2.0f;
    [SerializeField] private float _spawnStartDelay = 0;

    private System.Random _random;

    private void Start()
    {
        _random = new System.Random();
        InvokeRepeating(nameof(Spawn), _spawnStartDelay, _spawnDelayTime);
    }

    private void Spawn()
    {
        SpawnPoint spawnPoint = _spawnPoints[_random.Next(0, _spawnPoints.Length)];
        spawnPoint.SpawnEnemy();
    }
}

