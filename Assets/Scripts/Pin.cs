using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool _isPinned = false;
    [SerializeField] private float _speed = 20f;
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (!_isPinned) _rb.MovePosition(_rb.position + Vector2.up * _speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.GetComponent<Rotator>() != null)
        {
            _isPinned = true;
            transform.SetParent(collision.transform);
            Score.IncPinCount();
        }
        else if (collision.GetComponent<Pin>() != null)
        {
            FindObjectOfType<GameManager>().GameEnd();
        }
    }
}
