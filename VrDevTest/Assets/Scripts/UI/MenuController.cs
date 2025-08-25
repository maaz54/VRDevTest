using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI pauseResumeText;
    bool isPaused = false;

    public void TogglePause()
    {
        if (isPaused)
            Resume();
        else
            Pause();

    }

    private void Pause()
    {
        isPaused = true;
        Time.timeScale = 0f;
        pauseResumeText.text = "Resume";
    }

    private void Resume()
    {
        isPaused = false;
        Time.timeScale = 1f;
        pauseResumeText.text = "Pause";
    }

    public void RestartScene()
    {
        isPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
