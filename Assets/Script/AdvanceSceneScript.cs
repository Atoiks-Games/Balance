using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class AdvanceSceneScript : MonoBehaviour {

    public string levelName;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            SceneManager.LoadScene(levelName);
        }

	}
}
