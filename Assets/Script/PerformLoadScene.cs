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
            foreach (var ld in gameObj.GetComponentsInChildren<LoadScene>())
            {
                if (ld != null)
                {
                    if (ld.GetSceneNumber() == animator.GetInteger("NextScene"))
                    {
                        ld.Apply();
                        return;
                    }
                }
            }
        }
    }
}
