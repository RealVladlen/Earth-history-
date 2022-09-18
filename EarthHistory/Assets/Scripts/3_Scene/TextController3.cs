using System.Collections;
using UnityEngine;
using DG.Tweening;

public class TextController3 : MonoBehaviour
{
    [SerializeField] private GameObject _firstText, _endGameButton;

    private CanvasGroup _firstTextCanvas, _endGameButtonCanvas;

    private void Awake()
    {
        _firstTextCanvas = _firstText.GetComponent<CanvasGroup>();
        _endGameButtonCanvas = _endGameButton.GetComponent<CanvasGroup>();

        _firstTextCanvas.alpha = 0;
        _endGameButtonCanvas.alpha = 0;
    }

    private void Start()
    {
        ShowFirstText();
    }

    private void ShowFirstText()
    {
        StartCoroutine(StartDelayDelay());
    }

    private IEnumerator StartDelayDelay()
    {
        yield return new WaitForSeconds(3f);
        StartShow();
    }

    private void StartShow()
    {
        _firstText.SetActive(true);
        _firstTextCanvas.DOFade(1, 0.25f).onComplete += () =>
        {
            _firstTextCanvas.DOFade(0, 0.25f).SetDelay(20).onComplete += () =>
            {
                _firstText.SetActive(false);
                _endGameButton.SetActive(true);
                _endGameButtonCanvas.DOFade(1, 0.25f);
            };
        };
    }
}
