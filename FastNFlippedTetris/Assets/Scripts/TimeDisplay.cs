using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class TimeDisplay : MonoBehaviour
{
    public TMP_Text timeText;

    private void Update() {
        if(SceneManager.GetActiveScene().name == "FastNFlipped") {
            timeText.text = "TIME: \n" + Board.currTime.ToString("F2");
        } else {
            timeText.text = "TIME: " + Board.currTime.ToString("F2");
        }
    }
}
