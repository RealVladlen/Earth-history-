using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private List<Transform> _planets;

    [SerializeField] private TextControllersLevel2 _textController;

    [SerializeField] private float _speed;

    private Vector3 _target;
    private Vector3 _newTarget;

    private int _index;

    void Start()
    {
        _newTarget = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        _index = 0;
    }

    void Update()
    {
        Vector3 currentPosiotoin = Vector3.Lerp(transform.position, _target, _speed * Time.deltaTime);
        transform.position = currentPosiotoin;

        UpdateTarget();
        _target = _newTarget;
    }

    public void NextTarget()
    {
        _index++;

        UpdateTarget();
        UpdateLevelText();
    }

    private void UpdateTarget()
    {
        if (_index == 0)
            return;

        switch (_index)
        {
            case 1:
                _newTarget = new Vector3(_planets[_index-1].transform.position.x, _planets[_index - 1].transform.position.y + 1.5f, _planets[_index-1].transform.position.z + (-9));
                break;

            case 2:
                _speed = 4f;
                _newTarget = new Vector3(_planets[_index - 1].transform.position.x, _planets[_index - 1].transform.position.y + 0.7f, _planets[_index - 1].transform.position.z + (-2f));
                break;

            case 3:
                _speed = 4f;
                _newTarget = new Vector3(_planets[_index - 1].transform.position.x, _planets[_index - 1].transform.position.y + 0.7f, _planets[_index - 1].transform.position.z + (-2f));
                break;

            case 4:
                _speed = 4f;
                _newTarget = new Vector3(_planets[_index - 1].transform.position.x, _planets[_index - 1].transform.position.y + 0.7f, _planets[_index - 1].transform.position.z + (-2f));
                break;

            case 5:
                _speed = 4f;
                _newTarget = new Vector3(_planets[_index - 1].transform.position.x, _planets[_index - 1].transform.position.y + 0.7f, _planets[_index - 1].transform.position.z + (-2f));
                break;

            case 6:
                _speed = 4f;
                _newTarget = new Vector3(_planets[_index - 1].transform.position.x, _planets[_index - 1].transform.position.y + 1f, _planets[_index - 1].transform.position.z + (-3.5f));
                break;

            case 7:
                _speed = 4f;
                _newTarget = new Vector3(_planets[_index - 1].transform.position.x, _planets[_index - 1].transform.position.y + 1f, _planets[_index - 1].transform.position.z + (-3.5f));
                break;

            case 8:
                _speed = 4f;
                _newTarget = new Vector3(_planets[_index - 1].transform.position.x, _planets[_index - 1].transform.position.y + 0.8f, _planets[_index - 1].transform.position.z + (-2.5f));
                break;

            case 9:
                _speed = 4f;
                _newTarget = new Vector3(_planets[_index - 1].transform.position.x, _planets[_index - 1].transform.position.y + 0.7f, _planets[_index - 1].transform.position.z + (-2f));
                break;

            case 10:
                _speed = 4f;
                _newTarget = new Vector3(0, 7, -25);
                break;
        }
    }
    
    private void UpdateLevelText()
    {
        if (_index == 0)
            return;

        switch (_index)
        {
            case 1:
                _textController.SunStep();
                break;

            case 2:
                _textController.MercuryStep();
                break;

            case 3:
                _textController.VenusStep();
                break;

            case 4:
                _textController.EarthStep();
                break;

            case 5:
                _textController.MarsStep();
                break;

            case 6:
                _textController.JuiterStep();
                break;

            case 7:
                _textController.SaturnStep();
                break;

            case 8:
                _textController.UranusStep();
                break;

            case 9:
                _textController.NeptuneStep();
                break;
        }
    }
}
