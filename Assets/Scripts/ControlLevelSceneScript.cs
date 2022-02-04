using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlLevelSceneScript : MonoBehaviour
{
    [SerializeField] private string _level;
    
    public void ReturnMenu(){
        SceneManager.LoadScene("ThiefMenuScene");
    }

    public void StartGame(){
        SceneManager.LoadScene(_level);

        TimerScript.TimerStart();
    }
}
