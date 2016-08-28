using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class LoadScene : MonoBehaviour

{
    public string Scene1;
    private Scene currentScene;
    public bool onCollisionEnter {
        get
        {
            return onCollisionEnter;
        }
        private set
        {
            onCollisionEnter = value;
        }
    }

    void Start()
    {
        bool onCollisionEnter = true;
    }

    void Update()
    {
        
        
    }

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    public void Apply()
    {
              SceneManager.LoadScene(Scene1);
    }
}