using UnityEngine;

public class RotateAround : MonoBehaviour
{

    [SerializeField] private GameObject target;
    [SerializeField] private float _speed;
    [SerializeField] private bool _stateRandom;

    private void Start()
    {
        if (_stateRandom)
        {
            _speed += Random.Range(-100, 100);
        }
    }

    void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.up, _speed * Time.deltaTime);
    }
}
