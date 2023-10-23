using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Pin _pinPrefab;
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SpawnPin();
        }
    }
    private void SpawnPin()
    {
        Instantiate(_pinPrefab, transform.position, Quaternion.identity);
    }
}
