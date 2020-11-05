using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private UnityEngine.UI.Image _image;
    private Vector3 _buttonScale = new Vector3(0.97f, 0.94f);
    private Vector3 _defoultScale = new Vector3(1f, 1f);

    private void Start()
    {
        _image = GetComponent<UnityEngine.UI.Image>();        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.DOScale(_buttonScale, 0.3f);
        _image.DOColor(Color.yellow, 0.3f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.DOScale(_defoultScale, 0.3f);
        _image.DOColor(Color.white, 0.3f);       
    }
}
