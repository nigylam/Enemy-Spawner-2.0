using UnityEngine;

public class MoveToPlace : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _placesStorage;

    private Transform[] _places;
    private int _placeNumber;

    private void Start()
    {
        GetPlaces();
    }

    private void Update()
    {
        Transform place = _places[_placeNumber];
        transform.position = Vector3.MoveTowards(transform.position, place.position, _speed * Time.deltaTime);

        if (transform.position == place.position)
            SetNextPoint();
    }

    private void GetPlaces()
    {
        _places = new Transform[_placesStorage.childCount];

        for (int i = 0; i < _placesStorage.childCount; i++)
            _places[i] = _placesStorage.GetChild(i).GetComponent<Transform>();
    }

    private void SetNextPoint()
    {
        _placeNumber = (_placeNumber +1) % _places.Length;
        Vector3 nextPoint = _places[_placeNumber].transform.position;
        transform.forward = nextPoint - transform.position;
    }
}
