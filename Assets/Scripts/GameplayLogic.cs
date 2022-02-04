using System;
using UnityEngine;
using UnityEngine.UI;

public class GameplayLogic : MonoBehaviour
{
    [SerializeField] private int[] _breakInValues = new int[3];
    [SerializeField] private Button[] _pinsValues = new Button[3];
    [SerializeField] private GameObject _endGamePanel;

    public void onClickTool() {
        for(int i = 0; i < _breakInValues.Length; i++){
            int pinValue = Convert.ToInt32(_pinsValues[i].GetComponentInChildren<Text>().text);
            pinValue += _breakInValues[i];

            if ((pinValue <= 10) && (pinValue >= 0)){
                _pinsValues[i].GetComponentInChildren<Text>().text = pinValue.ToString();
            }       
        }
        
        Victory();
    }

    private void Victory(){
        int countCollectedPins = 0;

        for (int i = 1; i < _pinsValues.Length; i++) {
            if (_pinsValues[i].GetComponentInChildren<Text>().text == 
                    _pinsValues[i - 1].GetComponentInChildren<Text>().text){
                countCollectedPins++;
            }
        }

        if (countCollectedPins == _pinsValues.Length - 1){
            _endGamePanel.SetActive(true);
            TimerScript.TimerStop();
        }
    }
}
