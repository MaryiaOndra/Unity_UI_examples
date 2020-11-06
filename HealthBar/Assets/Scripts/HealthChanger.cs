using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]

public class HealthChanger : MonoBehaviour
{
    private Slider _slider;
    private float _currentValue;
    private float _previousValue;

    private void Start()
    {
        _slider = GetComponent<Slider>();
        _currentValue = _slider.value;
    }

    public void AddHealth(float value) 
    {
        _previousValue = _currentValue;
        Debug.Log(_previousValue);
        _currentValue = _currentValue + 10.0f;
        Debug.Log(_currentValue);
        _slider.value = Mathf.Lerp(_previousValue, _currentValue, value);        
    }

    public void TakeHealth() 
    {
        _slider.value -= 10;    
    }
}
