using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class LoadScene : MonoBehaviour

{
    public string Scene1;
    public string Scene2;
    public string Scene3;
    public string Scene4;
    public string Scene5;
    public string Scene6;
    public string Scene7;
    public string Scene8;
    public string Scene9;
    public string Scene10;
    public string Scene11;
    public string Scene12;
    public string Scene13;
    public string Scene14;
    public string Scene15;
    public string Scene16;
    public string Scene17;


    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    public void Apply()
    {
        switch (this.gameObject.name)
        {
            case "1":
                SceneManager.LoadScene(Scene1);
                break;

            case "2":
                SceneManager.LoadScene(Scene2);
                break;

            case "3":
                SceneManager.LoadScene(Scene3);
                break;

            case "4":
                SceneManager.LoadScene(Scene4);
                break;

            case "5":
                SceneManager.LoadScene(Scene5);
                break;

            case "6":
                SceneManager.LoadScene(Scene6);
                break;

            case "7":
                SceneManager.LoadScene(Scene7);
                break;

            case "8":
                SceneManager.LoadScene(Scene8);
                break;

            case "9":
                SceneManager.LoadScene(Scene9);
                break;

            case "10":
                SceneManager.LoadScene(Scene10);
                break;

            case "11":
                SceneManager.LoadScene(Scene11);
                break;

            case "12":
                SceneManager.LoadScene(Scene12);
                break;

            case "13":
                SceneManager.LoadScene(Scene13);
                break;

            case "14":
                SceneManager.LoadScene(Scene14);
                break;

            case "15":
                SceneManager.LoadScene(Scene15);
                break;

            case "16":
                SceneManager.LoadScene(Scene16);
                break;

            case "17":
                SceneManager.LoadScene(Scene17);
                break;
        }
    }
}