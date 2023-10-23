using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool _isEnded = false;
    private Rotator _rotator;
    private Spawner _spawner;
    private Animator _animator;
    private void Start()
    {
        _animator = GetComponent<Animator>();
        _rotator = FindObjectOfType<Rotator>();
        _spawner = FindObjectOfType<Spawner>();
    }
    public void GameEnd()
    {
        if (!_isEnded)
        {
            _rotator.enabled = false;
            _spawner.enabled = false;

            _animator.SetTrigger("EndGame");

            _isEnded = true;
        }
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
