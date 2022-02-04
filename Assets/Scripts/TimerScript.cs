using System;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public float START_TIME;

    [SerializeField] private Text _timerText;
    [SerializeField] private GameObject _endGamePanel;

    private float _currentTime;
    private bool _isGameOver = false;
    private static bool _isWork = false;

    public static void TimerStop(){
        _isWork = false;
    }

    public static void TimerStart(){
        _isWork = true;
    }

    void Start()
    {
        _currentTime = START_TIME;
    }

    void Update()
    {
        if (_isWork){
            if (_currentTime < 0) {

                if (!_isGameOver) {
                    GameOver();
                }

                return;
            } 
            else {
                _currentTime -= Time.deltaTime;
                _timerText.text = Math.Round(_currentTime).ToString();
            }
        }
    }

    private void GameOver(){
        _isGameOver = true;
        _endGamePanel.SetActive(true);
    }
}
