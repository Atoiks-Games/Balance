using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class ButtonScript : MonoBehaviour
{
    public Button startText;

    void Start()
    {
        startText = startText.GetComponent<Button>();
    }

    public void StartLevel()
    {
        SceneManager.LoadScene("LevelHub");
    }

}






