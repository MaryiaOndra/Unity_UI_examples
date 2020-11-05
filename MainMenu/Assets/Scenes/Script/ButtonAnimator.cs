using UnityEngine;
using DG.Tweening;

public class ButtonAnimator : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _buttonScale = new Vector3(0.97f, 0.94f);
    private Tween _playAnimation;

    void Start()
    {
       _playAnimation = transform.DOScale(_buttonScale, _speed).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }

    public void StopAnimation() 
    {
        if (_playAnimation.active)
        {
            transform.DOKill();
        } 
    }
}
