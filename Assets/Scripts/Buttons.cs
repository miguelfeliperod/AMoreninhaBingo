using UnityEngine;
using UnityEngine.SceneManagement;
public class Buttons : MonoBehaviour
{
    public void OnRaffleButtonClick() => SceneManager.LoadScene(SceneNames.RaffleSceneName);

    public void OnPlayerButtonClick() => SceneManager.LoadScene(SceneNames.PlayerSceneName);
}
