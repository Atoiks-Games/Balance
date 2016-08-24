using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public GameObject bindingObject;
    public Vector3 offset;
    public RotLocReset[] resetObjects;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetAxis("Quit") < 0)
            Application.Quit();
        if (Input.GetAxis("Quit") > 0)
        {
            foreach (var item in resetObjects)
                if (item != null)
                    item.ApplyReset();
        }
    }

    void FixedUpdate()
    {
        if (bindingObject != null)
        {
            this.transform.position = bindingObject.transform.position + offset;
            this.transform.LookAt(bindingObject.transform);
        }
    }
}
