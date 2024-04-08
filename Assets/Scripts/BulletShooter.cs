using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BulletShooter : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private float _bulletShootDelay;
    [SerializeField] private Transform _target;

    private void Update()
    {
        InvokeRepeating(nameof(Shoot), 0, _bulletShootDelay);
    }

    private void Shoot()
    {
        Vector3 direction = (_target.position - transform.position).normalized;
        GameObject bullet = Instantiate(_bullet, transform.position + direction, Quaternion.identity);
        bullet.GetComponent<Rigidbody>().transform.up = direction;
        bullet.GetComponent<Rigidbody>().velocity = direction * _speed;
    }
}
