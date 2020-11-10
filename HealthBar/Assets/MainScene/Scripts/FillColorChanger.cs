using UnityEngine;
using UnityEngine.UI;

public class FillColorChanger : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Color _from;
    [SerializeField] private Color _to;    

    [ContextMenu("LoadFromColor")]
    private void LoadFromColor()
    {
        if (_image != null)
        {
            _from = _image.color;
        }
    }

    public void ChangeFillColor(float position)
    {        
        _image.color = Color.Lerp(_from, _to, position * 0.01f);
    }
}
