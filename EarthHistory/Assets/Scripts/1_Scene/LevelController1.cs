using System.Collections.Generic;
using UnityEngine;

public class LevelController1 : MonoBehaviour
{
    [SerializeField] private List<CompoundH> _listH;
    [SerializeField] private TextControllerLevels1 _textController;

    public void ClearH()
    {
        for (int i = 0; i < _listH.Count; i++)
        {
            Destroy(_listH[i].gameObject);
        }

        _textController.SecondStepText();
    }

    public void CloseFirstText()
    {
        _textController.CloseFirstStep();
    }
}
