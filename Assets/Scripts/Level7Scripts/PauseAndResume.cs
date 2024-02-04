using UnityEngine;

public class PauseAndResume : MonoBehaviour
{
    public static bool isPaused;
    public static void PauseGame()
    {
        Time.timeScale = 0f;
        isPaused = true;
    }

    public static void ResumeGame()
    {
        Time.timeScale = 1f;
        isPaused = false;
    }
}
