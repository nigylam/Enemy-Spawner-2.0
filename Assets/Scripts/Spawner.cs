using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _spawnPoints;
    [SerializeField] private float _spawnDelayTime = 2.0f;
    [SerializeField] private float _spawnStartDelay = 0;

    private void Start()
    {
        InvokeRepeating(nameof(Spawn), _spawnStartDelay, _spawnDelayTime);
    }

    private void Spawn()
    {
        SpawnPoint spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)];
        spawnPoint.SpawnEnemy();
    }
}

