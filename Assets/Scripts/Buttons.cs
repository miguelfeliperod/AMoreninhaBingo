using UnityEngine;
using UnityEngine.SceneManagement;
public class Buttons : MonoBehaviour
{
    public void GoToMenuScene() => SceneManager.LoadScene(SceneNames.MenuSceneName);
    public void GoToPlayerScene() => SceneManager.LoadScene(SceneNames.PlayerSceneName);
    public void GoToRaffleScene() => SceneManager.LoadScene(SceneNames.RaffleSceneName);

}
