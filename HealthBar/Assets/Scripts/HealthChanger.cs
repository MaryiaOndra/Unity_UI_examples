using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]

public class HealthChanger : MonoBehaviour
{
    private Slider _slider;

    private void Start()
    {
        _slider = GetComponent<Slider>();
    }

    public void AddHealth() 
    {
        _slider.value += 10;
    }

    public void TakeHealth() 
    {
        _slider.value -= 10;    
    }
}
