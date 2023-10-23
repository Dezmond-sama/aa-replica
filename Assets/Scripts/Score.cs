using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text _score;
    private static Score _instance;
    private int _pinCount;
    public static void SetPinCount(int value)
    {
        _instance._pinCount = value;
        _instance._score.text = _instance._pinCount.ToString();
    }
    public static void IncPinCount()
    {
        _instance._pinCount++;
        _instance._score.text = _instance._pinCount.ToString();
    }
    private void Start()
    {
        _instance = this;
        _score = GetComponent<Text>();
        SetPinCount(0);
    }
}
