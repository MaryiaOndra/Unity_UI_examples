using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextColorChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private Color _from;
    [SerializeField] private Color _to;

    public void ChangeTextColor(float position)
    {
        _text.color = Color.Lerp(_from, _to, position * 0.01f);
    }
}
