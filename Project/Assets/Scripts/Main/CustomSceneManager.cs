using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomSceneManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Project");
    }

    public void CodeRepo()
    {
        Application.OpenURL("https://github.com/vUltiQ/ProjectFinal");
    }
}
