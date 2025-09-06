using DG;
using DG.Tweening;
using UnityEngine;

public class WaveAnimation : MonoBehaviour
{
    [SerializeField] Transform waves;
    [SerializeField] float speed;

    private void Start() {
        WaveAnimations();
    }
    private void WaveAnimations() {
        float val = 0f;
        DOTween.To(() => val, x => {
            val = x;
            float xPos = val * 4f;
            float yPos = Mathf.Sin(val * Mathf.PI) * 0.5f;
            waves.position = new Vector3(xPos, yPos, 0f);
        }, 1f, speed)
        .SetEase(Ease.Linear)
        .OnComplete(WaveAnimations);
    }
}
