using UnityEngine;
using UnityEngine.UI;

public class GameState : MonoBehaviour
{
    [SerializeField]
    private int _countToFinish = 10;

    [SerializeField]
    private GameObject _canvas;

    [SerializeField]
    private Text _endGameText;

    private int _counter;

    private void Start()
    {
        _canvas.SetActive(false);
    }

    public void Lose()
    {
        _canvas.SetActive(true);
        _endGameText.text = "Вы проиграли!";
    }

    public void Win()
    {
        _canvas.SetActive(false);
        _endGameText.text = "Вы выиграли!";
    }

    public void IncreaseCounter()
    {
        _counter++;
        CheckGameFinished();
    }

    private void CheckGameFinished()
    {
        if (_counter >= _countToFinish)
        {
            Win();
        }
    }
}
