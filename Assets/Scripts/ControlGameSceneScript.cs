using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControlGameSceneScript : MonoBehaviour
{
    private string _levelStory1 = "История №1\n\nСегодня вы намерены ограбить своего соседа Мартина. " +
                                  "\nГод назад он занял у вас деньги и не отдает. Сегодня вы намерены " +
                                  "вернуть себе свои деньги.";
    
    private string _levelStory2 = "История №2\n\nИногда, когда вы смотрите на дом вашего близкого соседа Джо, " +
                                  "вам кажется, что он у вас что то украл. Поэтому сегодня вы решили украсть " +
                                  "что нибудь у него.";
    
    private string _levelStory3 = "История №3\n\nСегодня вы потеряли ключи от своего дома. Придется применить " +
                                  "ваши профессиональные навыки и показать миру, на что вы способны, взломав " +
                                  "самого себя.";
    
    [SerializeField] private Text _storyText;

    private string _level;

    private void Start()
    {
        _level = "Level_1";
        _storyText.text = _levelStory1;
    }

    public void StartGame(){
        SceneManager.LoadScene(_level);

        TimerScript.TimerStart();
    }
    
    public void SelectLevel(string selectedLevel)
    {
        _level = selectedLevel;
        switch (selectedLevel)
        {
            case "Level_1":
                _storyText.text = _levelStory1;
                break;
            
            case "Level_2": 
                _storyText.text = _levelStory2;
                break;
            
            case "Level_3": 
                _storyText.text = _levelStory3;
                break;
        }
    }
}

