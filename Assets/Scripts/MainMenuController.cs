using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public string levelToStart;

    private void Start()
    {
        AudioManager.instance.PlayTitle();
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(levelToStart);

        AudioManager.instance.PlayNextBGM();

        AudioManager.instance.PlaySFXPitchAdjusted(5);
    }

    public void QuitGame()
    {
        Application.Quit();

        Debug.Log("Quitting the Game");

        AudioManager.instance.PlaySFXPitchAdjusted(5);
    }
}
