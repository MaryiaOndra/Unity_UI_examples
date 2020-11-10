using UnityEngine;

public class PlayersStats : MonoBehaviour
{
    [SerializeField] private float _health;

    public void ChangeHealth(float value) 
    {
        _health = Mathf.Lerp(0.0f, 100.0f, value * 0.01f);
    }
}
