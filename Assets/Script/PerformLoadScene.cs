using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PerformLoadScene : StateMachineBehaviour
{
    private Scene currentScene;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        currentScene = SceneManager.GetActiveScene();
        foreach (var gameObj in currentScene.GetRootGameObjects())
        {
            // Load in children since Goal must be wrapped inside a Board
            LoadScene ld = gameObj.GetComponentInChildren<LoadScene>();
            if (ld != null)
            {
                if (ld.onCollisionEnter == true) {
                    ld.Apply();
                }
                return;
            }
        }
    }
}
