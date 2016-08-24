using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadScene : StateMachineBehaviour
{
    public string nextScene;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        SceneManager.LoadScene(nextScene);
    }
}
