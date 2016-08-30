using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public GameObject sphere;
    public GameObject board;
    public Vector3 offset;
    public RotLocReset[] resetObjects;
    public float restartHeight = 10; // Note: Only values greater than 0 are being tested
    private bool hasBeenDone = false;


    void Start()
    {

    }

    void Update()
    {
        if (Input.GetAxis("Quit") < 0)
            Application.Quit();
        if (Input.GetAxis("Quit") > 0)
            ResetPos();

        if (restartHeight > 0)
        {
            if (Vector3.Distance(sphere.transform.position, board.transform.position) > restartHeight)
            {
                ResetPos();
            }
        }
        if (Input.GetKeyDown("e"))
        {
            SceneManager.LoadScene("LevelHub");
        }

    }


    void ResetPos()
    {
        foreach (var item in resetObjects)
            if (item != null)
            {
                item.ApplyReset();
                transform.Translate(Vector3.forward);
                transform.Translate(Vector3.back);
            }
    }

    void FixedUpdate()
    {
        if (sphere != null)
        {
            this.transform.position = sphere.transform.position + offset;
            this.transform.LookAt(sphere.transform);
            BeginningReset();
        }
    }
    void BeginningReset()
    {
        if (hasBeenDone == false)
        {
            ResetPos();
            hasBeenDone = true;
        }
    }
}
