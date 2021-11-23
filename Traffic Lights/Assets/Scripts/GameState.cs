using UnityEngine;
using UnityEngine.UI;

public class GameState : MonoBehaviour
{
    [SerializeField]
    private int _countToFinish = 10;

    [SerializeField]
    private GameObject _canvas;

    [SerializeField]
    private Text _carsCountText;

    [SerializeField]
    private Text _endGameText;

    private int _counter;

    private void Start()
    {
        _canvas.SetActive(false);
        SetText();
    }

    public void Lose()
    {
        _canvas.SetActive(true);
        Time.timeScale = 0;
        _endGameText.text = "Вы проиграли!";
    }

    public void Win()
    {
        _canvas.SetActive(true);
        Time.timeScale = 0;
        _endGameText.text = "Вы выиграли!";
    }

    public void IncreaseCounter()
    {        
        _counter++;
        SetText();
        CheckGameFinished();
    }

    private void CheckGameFinished()
    {
        if (_counter >= _countToFinish)
        {
            Win();
        }
    }   

    private void SetText()
    {
        _carsCountText.text = "Машин для победы: " + (_countToFinish - _counter).ToString();
    }
}
