using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextControllersLevel2 : MonoBehaviour
{
    [SerializeField] private GameObject _nextButton, _firstText, _sun, _mercury, _venus, _earth, _mars, _juoiter, _saturn, _uranus, _neptune, _nextLevelButton;

    private CanvasGroup _nextButtonCanvas, _firstCanvas, _sunCanvas, _mercuryCanvas, _venusCanvas, _earthCanvas, _marsCanvas, _jupiterCanvas, _saturnCanvas, _uranusCanvas, _neptuneCanvas, _nextLevelButtonCanvas;

    private Button _next;
    private void Awake()
    {
        _next = _nextButton.GetComponent<Button>();

        _nextButtonCanvas = _nextButton.GetComponent<CanvasGroup>();
        _firstCanvas = _firstText.GetComponent<CanvasGroup>();
        _sunCanvas = _sun.GetComponent<CanvasGroup>();
        _mercuryCanvas = _mercury.GetComponent<CanvasGroup>();
        _venusCanvas = _venus.GetComponent<CanvasGroup>();
        _earthCanvas = _earth.GetComponent<CanvasGroup>();
        _marsCanvas = _mars.GetComponent<CanvasGroup>();
        _jupiterCanvas = _juoiter.GetComponent<CanvasGroup>();
        _saturnCanvas = _saturn.GetComponent<CanvasGroup>();
        _uranusCanvas = _uranus.GetComponent<CanvasGroup>();
        _neptuneCanvas = _neptune.GetComponent<CanvasGroup>();
        _nextLevelButtonCanvas = _nextLevelButton.GetComponent<CanvasGroup>();


        _nextButtonCanvas.alpha = 0;
        _firstCanvas.alpha = 1;
        _sunCanvas.alpha = 0;
        _mercuryCanvas.alpha = 0;
        _venusCanvas.alpha = 0;
        _earthCanvas.alpha = 0;
        _marsCanvas.alpha = 0;
        _jupiterCanvas.alpha = 0;
        _saturnCanvas.alpha = 0;
        _uranusCanvas.alpha = 0;
        _neptuneCanvas.alpha = 0;
        _nextLevelButtonCanvas.alpha = 0;
    }

    private void Start()
    {
        _firstText.SetActive(true);
        _firstCanvas.DOFade(0, 0.5f).SetDelay(8).onComplete += () => 
        {
            _nextButton.SetActive(true);
            _nextButtonCanvas.DOFade(1, 0.5f);
            _firstText.SetActive(false);
        };
    }

    public void SunStep()
    {
        _next.enabled = false;

        _nextButtonCanvas.DOFade(0, 0.5f).onComplete += () =>
        {
            _nextButton.SetActive(false);
            _sun.SetActive(true);

            _sunCanvas.DOFade(1, 1f).onComplete += () =>
            {
                _sunCanvas.DOFade(0, 0.5f).SetDelay(35).onComplete += () =>
                {
                    _nextButton.SetActive(true);
                    _nextButtonCanvas.DOFade(1, 0.5f);
                    _next.enabled = true;
                    _sun.SetActive(false);
                    return;
                };
            };
        };
    }

    public void MercuryStep()
    {
        _next.enabled = false;

        _nextButtonCanvas.DOFade(0, 0.5f).onComplete += () =>
        {
            _nextButton.SetActive(false);
            _mercury.SetActive(true);

            _mercuryCanvas.DOFade(1, 1f).onComplete += () =>
            {
                _mercuryCanvas.DOFade(0, 0.5f).SetDelay(25).onComplete += () =>
                {
                    _nextButton.SetActive(true);
                    _nextButtonCanvas.DOFade(1, 0.5f);
                    _next.enabled = true;
                    _mercury.SetActive(false);
                    return;
                };
            };
        };
    }

    public void VenusStep()
    {
        _next.enabled = false;

        _nextButtonCanvas.DOFade(0, 0.5f).onComplete += () =>
        {
            _nextButton.SetActive(false);
            _venus.SetActive(true);

            _venusCanvas.DOFade(1, 1f).onComplete += () =>
            {
                _venusCanvas.DOFade(0, 0.5f).SetDelay(40).onComplete += () =>
                {
                    _nextButton.SetActive(true);
                    _nextButtonCanvas.DOFade(1, 0.5f);
                    _next.enabled = true;
                    _venus.SetActive(false);
                    return;
                };
            };
        };
    }

    public void EarthStep()
    {
        _next.enabled = false;

        _nextButtonCanvas.DOFade(0, 0.5f).onComplete += () =>
        {
            _nextButton.SetActive(false);
            _earth.SetActive(true);

            _earthCanvas.DOFade(1, 1f).onComplete += () =>
            {
                _earthCanvas.DOFade(0, 0.5f).SetDelay(95).onComplete += () =>
                {
                    _nextButton.SetActive(true);
                    _nextButtonCanvas.DOFade(1, 0.5f);
                    _next.enabled = true;
                    _earth.SetActive(false);
                    return;
                };
            };
        };
    }

    public void MarsStep()
    {
        _next.enabled = false;

        _nextButtonCanvas.DOFade(0, 0.5f).onComplete += () =>
        {
            _nextButton.SetActive(false);
            _mars.SetActive(true);

            _marsCanvas.DOFade(1, 1f).onComplete += () =>
            {
                _marsCanvas.DOFade(0, 0.5f).SetDelay(50).onComplete += () =>
                {
                    _nextButton.SetActive(true);
                    _nextButtonCanvas.DOFade(1, 0.5f);
                    _next.enabled = true;
                    _mars.SetActive(false);
                    return;
                };
            };
        };
    }
    public void JuiterStep()
    {
        _next.enabled = false;

        _nextButtonCanvas.DOFade(0, 0.5f).onComplete += () =>
        {
            _nextButton.SetActive(false);
            _juoiter.SetActive(true);

            _jupiterCanvas.DOFade(1, 1f).onComplete += () =>
            {
                _jupiterCanvas.DOFade(0, 0.5f).SetDelay(63).onComplete += () =>
                {
                    _nextButton.SetActive(true);
                    _nextButtonCanvas.DOFade(1, 0.5f);
                    _next.enabled = true;
                    _juoiter.SetActive(false);
                    return;
                };
            };
        };
    }
    public void SaturnStep()
    {
        _next.enabled = false;

        _nextButtonCanvas.DOFade(0, 0.5f).onComplete += () =>
        {
            _nextButton.SetActive(false);
            _saturn.SetActive(true);

            _saturnCanvas.DOFade(1, 1f).onComplete += () =>
            {
                _saturnCanvas.DOFade(0, 0.5f).SetDelay(75).onComplete += () =>
                {
                    _nextButton.SetActive(true);
                    _nextButtonCanvas.DOFade(1, 0.5f);
                    _next.enabled = true;
                    _saturn.SetActive(false);
                    return;
                };
            };
        };
    }
    public void UranusStep()
    {
        _next.enabled = false;

        _nextButtonCanvas.DOFade(0, 0.5f).onComplete += () =>
        {
            _nextButton.SetActive(false);
            _uranus.SetActive(true);

            _uranusCanvas.DOFade(1, 1f).onComplete += () =>
            {
                _uranusCanvas.DOFade(0, 0.5f).SetDelay(67).onComplete += () =>
                {
                    _nextButton.SetActive(true);
                    _nextButtonCanvas.DOFade(1, 0.5f);
                    _next.enabled = true;
                    _uranus.SetActive(false);
                    return;
                };
            };
        };
    }
    public void NeptuneStep()
    {
        _next.enabled = false;

        _nextButtonCanvas.DOFade(0, 0.5f).onComplete += () =>
        {
            _nextButton.SetActive(false);
            _neptune.SetActive(true);

            _neptuneCanvas.DOFade(1, 1f).onComplete += () =>
            {
                _neptuneCanvas.DOFade(0, 0.5f).SetDelay(50).onComplete += () =>
                {
                    _nextLevelButton.SetActive(true);
                    _nextLevelButtonCanvas.DOFade(1, 1);
                    _neptune.SetActive(false);
                    return;
                };
            };
        };
    }
}
