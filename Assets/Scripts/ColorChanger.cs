using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public SpriteRenderer Target; 
    [SerializeField] private float _duration; 

    private Color _startColor; 
    [SerializeField] private Color _targetColor;

    private float _runningtime;

    void Start()
    {
        Target = GetComponent<SpriteRenderer>(); 
        _startColor = Target.color;
    }


    void Update()
    {
        _runningtime += Time.deltaTime;
        float normalizeRunningTime = _runningtime / _duration;

        if (_runningtime <= _duration)
        {
            Target.color = Color.Lerp(_startColor, _targetColor, normalizeRunningTime); // меняет текущий цвет на нужный
        }

        if (_runningtime > _duration)
        {
            Target.color = Color.Lerp(_targetColor, _startColor, normalizeRunningTime - 1);
        }

        if (Target.color == _startColor)
        {
            _runningtime = 0;
        }
    }
}
