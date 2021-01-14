using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RandomColor : MonoBehaviour
{
    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        button.onClick.AddListener(ChangeButtonColor); 
    }

    private void OnDisable()
    {
        button.onClick.RemoveListener(ChangeButtonColor);
    }

    private void ChangeButtonColor() 
    {
        GetComponent<Image>().color = RandomizeColor();
    }

    private Color RandomizeColor() 
    {
        return new Color
            (
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f)
            );
    }
}
