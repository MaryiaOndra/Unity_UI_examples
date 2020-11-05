using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;
using UnityEngine.UI;

public class ButtonAnimator : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private float _speed;

    private Vector3 _buttonScale = new Vector3(0.97f, 0.94f);
    private Tween _playAnimation;
    private Image _image;

    void Start()
    {
        _image = GetComponent<Image>();
        AnimateButton();
    }

    private void AnimateButton() 
    {
        _playAnimation = transform.DOScale(_buttonScale, _speed).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _playAnimation.Pause();
        _image.DOColor(Color.yellow, 0.3f);        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _playAnimation.Play();
        _image.DOColor(Color.white, 0.3f);
    }
}
