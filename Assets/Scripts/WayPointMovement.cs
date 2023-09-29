using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointMovement : MonoBehaviour
{
    [SerializeField] private Transform _path; //ссылку на корневой объект Трансформ

    [SerializeField] private Transform[] _points; //массив с точками пути

    private int _currentPoint;
    [SerializeField] private float _speed;

    private void Start()
    {
        _points = new Transform[_path.childCount]; //массив для хранения точек

        for (int i = 0; i < _path.childCount; i++)
        {
            _points[i] = _path.GetChild(i);    
        }
    }

    private void Update()
    {
        Transform target = _points[_currentPoint];

        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);
        
        if (transform.position == target.position)
        {
            _currentPoint++;
            if (_currentPoint >= _points.Length)
            {
                _currentPoint = 0;
            }
        }
    }
}
