using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class ScensController : MonoBehaviour
{
    [SerializeField] private CanvasGroup _fadePanel;

    private void Awake()
    {
        _fadePanel.alpha = 1.0f;
    }

    private void Start()
    {
        _fadePanel.DOFade(0, 0.5f);
    }

    public void ChangeScene(string sceneName)
    {
        _fadePanel.DOFade(1, 1f).onComplete += () => 
        {
            SceneManager.LoadScene(sceneName);
        };
    }
}
