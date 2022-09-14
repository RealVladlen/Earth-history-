using DG.Tweening;
using UnityEngine;

public class TextController : MonoBehaviour
{
    [SerializeField] private GameObject _firstText, _secondText, _thirdText;
    private CanvasGroup _firstTextCanvas, _secondTextCanvas, _thirdTextCanvas;


    [SerializeField] private GameObject _universe, _universeText, _nextButton;
    private CanvasGroup _universeCanvas, _universeTextCanvas, _nextButtonCanvas;



    private void Awake()
    {
        _firstTextCanvas = _firstText.GetComponent<CanvasGroup>();
        _secondTextCanvas = _secondText.GetComponent<CanvasGroup>();
        _thirdTextCanvas = _thirdText.GetComponent<CanvasGroup>();

        _universeCanvas = _universe.GetComponent<CanvasGroup>();
        _universeTextCanvas = _universeText.GetComponent<CanvasGroup>();
        _nextButtonCanvas = _nextButton.GetComponent<CanvasGroup>();

        _firstTextCanvas.alpha = 0;
        _secondTextCanvas.alpha = 0;
        _thirdTextCanvas.alpha = 0;
        _universeCanvas.alpha = 0;
        _universeTextCanvas.alpha = 0;
        _nextButtonCanvas.alpha = 0;
    }

    private void Start()
    {
        _firstTextCanvas.DOFade(1, 0.25f).onComplete += () =>
        {
            _firstTextCanvas.DOFade(0, 0.25f).SetDelay(7);
        };
    }

    public void SecondStepText()
    {
        GetComponent<Explosion>().ExplosionSound();

        _secondText.SetActive(true);
        _secondTextCanvas.DOFade(1, 0.25f).onComplete += () =>
        {
            _secondTextCanvas.DOFade(0, 0.25f).SetDelay(7).onComplete += () =>
            {
                _thirdText.SetActive(true);
                _thirdTextCanvas.DOFade(1, 0.25f).SetDelay(0.5f).onComplete += () =>
                {
                    _thirdTextCanvas.DOFade(0, 0.25f).SetDelay(15).onComplete += () =>
                    {
                        ThirdStep();
                    };
                };
            };
        };
    }

    public void ThirdStep()
    {
        _universe.SetActive(true);
        _universeCanvas.DOFade(1, 0.25f);

        _universeText.SetActive(true);
        _universeTextCanvas.DOFade(1, 0.25f).onComplete += () => 
        {
            _universeTextCanvas.DOFade(0, 0.25f).SetDelay(20).onComplete += () =>
            {
                _nextButton.SetActive(true);
                _nextButtonCanvas.DOFade(1, 0.25f);
            };
        };
    }
}
