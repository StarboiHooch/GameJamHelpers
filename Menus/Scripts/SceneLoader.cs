using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField]
    private string SceneName;
    public void LoadScene()
    {
        SceneManager.LoadScene(SceneName, LoadSceneMode.Single);
    }
}
