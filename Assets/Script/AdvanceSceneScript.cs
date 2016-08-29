using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class AdvanceSceneScript : MonoBehaviour
{
    public string levelName;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            SceneManager.LoadScene(levelName);
        }
    }
}