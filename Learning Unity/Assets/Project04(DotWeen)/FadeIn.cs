using DG.Tweening;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;

    public void ChangeFader()
    {
        ChangeAlfa();
        ChangeColor();
    }
    public void ChangeAlfa()
    {
        _spriteRenderer.DOFade(0, 1.5f).SetLoops(-1, LoopType.Yoyo);
    }
    public void ChangeColor()
    {
        _spriteRenderer.DOColor(Color.red, 1.5f).SetLoops(-1, LoopType.Yoyo);
    }
}
