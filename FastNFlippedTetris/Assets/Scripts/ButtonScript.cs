using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void LoadMainMenu() {
        SceneManager.LoadScene("MainMenu");
    }

    public void PlayAgain() {
        SceneManager.LoadScene("FastNFlipped");
    }

    public void Quit() {
        Application.Quit();
    }
}
