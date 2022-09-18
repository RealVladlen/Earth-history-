using UnityEngine;

public class CompoundH : MonoBehaviour
{
    [SerializeField] private LevelController1 _controller;
    [SerializeField] private float speed;
    [SerializeField] private float minSpeed;
    [SerializeField] private float maxSpeed;

    private Vector3 startPos;
    private Vector3 endPos;
    private Vector3 _pointScreen;

    private bool _state;

    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);

        startPos = gameObject.transform.position;

        RandomPos();
    }

    void Update()
    {
        if (_state == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPos, Time.deltaTime * speed);

            if (Vector3.Distance(transform.position, endPos) < 0.01f)
            {
                RandomPos();
            }
        }
    }

    void RandomPos()
    {
        endPos = new Vector3(startPos.x + Random.Range(-2f, 2f), startPos.y + Random.Range(-2f, 2f), startPos.z);
        speed = Random.Range(minSpeed, maxSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        CompoundH h = other.GetComponent<CompoundH>();
        if (h)
        {
            _controller.ClearH();
            _controller.CloseFirstText();
        }
    }

    private void OnMouseDown()
    {
        _state = true;
        _pointScreen = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    }

    private void OnMouseUp()
    {
        _state = false;
    }
    private void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, _pointScreen.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
        transform.position = curPosition;
    }
}
