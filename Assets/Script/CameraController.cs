using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public GameObject binding_obj;
    public Vector3 offset;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
            Application.Quit();
        this.transform.position = binding_obj.transform.position + offset;
        this.transform.LookAt(binding_obj.transform);
    }
}
