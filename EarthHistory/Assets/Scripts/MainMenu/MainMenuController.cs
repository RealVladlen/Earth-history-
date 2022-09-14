using UnityEngine;
using DG.Tweening;
public class MainMenuController : MonoBehaviour
{
    [SerializeField] private CanvasGroup _gameName, _startGameButton;

    private void Awake()
    {
        _gameName.alpha = 0;
        _startGameButton.alpha = 0;
    }

    void Start()
    {
        _gameName.DOFade(1, 3).SetDelay(0.5f);
        _startGameButton.DOFade(1, 3).SetDelay(0.5f);
    }
}
