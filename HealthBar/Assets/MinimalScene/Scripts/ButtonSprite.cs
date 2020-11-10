using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonSprite : MonoBehaviour
{
    [SerializeField] private Sprite _idle;
    [SerializeField] private Sprite _pressed;

    private static bool _isPressed = false;
    private Button _button;

    private void Start()
    {
        _button = GetComponent<Button>();
    }

    public void ChangeSprite() 
    {
        if (!_isPressed)
        {
            _button.image.sprite = _pressed;
            _isPressed = true;
        }
        else 
        {
            _button.image.sprite = _idle;
            _isPressed = false;
        }
    }
}
