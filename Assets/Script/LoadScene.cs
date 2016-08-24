using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadScene : MonoBehaviour
{
    public string nextScene;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    public void Apply()
    {
        SceneManager.LoadScene(nextScene);
    }
}
