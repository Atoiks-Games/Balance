using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class LoadScene : MonoBehaviour

{
    public int Scene;

    public int GetSceneNumber()
    {
        return Scene;
    }
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    public void Apply()
    {
        SceneManager.LoadScene(Scene);
    }
}