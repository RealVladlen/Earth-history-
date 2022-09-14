
using UnityEngine;

public class RotateAround : MonoBehaviour
{

    [SerializeField] private GameObject target;
    [SerializeField] private float _speed;

    void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.up, _speed * Time.deltaTime);
    }
}
