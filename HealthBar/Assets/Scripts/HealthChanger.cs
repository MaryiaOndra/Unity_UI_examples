using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

[RequireComponent(typeof(Slider))]
public class HealthChanger : MonoBehaviour
{
    [SerializeField] private Text _notice;
    [SerializeField] private Image _fill;

    private Slider _slider;   

    private float _interval = 10.0f;
    private float _duration = 0.3f;
    private float _startValue = 50.0f;
    private float _nextValue;

    private void Start()
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = 100.0f;
        _slider.DOValue(_startValue, _duration).SetEase(Ease.InCubic);
    }

    public void ChangeValue(float sign) 
    {
        _nextValue = _slider.value + _interval * sign;
        _slider.DOValue(_nextValue, _duration).SetEase(Ease.Linear);
        CheckValue();
    }

    private void CheckValue()
    {
        if (_nextValue > _slider.maxValue)
        {
            _notice.text = "MAXIMUM HEALTH!";
        }
        else if (_nextValue < _slider.minValue)
        {
            _notice.text = "YOU'RE DEAD!";
        }
        else if(_nextValue < _slider.value)
        {
            _notice.text = "- 10";
        }
        else if (_nextValue > _slider.value)
        {
            _notice.text = "+ 10";
        }
        else
        {
            _notice.text = string.Empty;
        }
    }    
}
