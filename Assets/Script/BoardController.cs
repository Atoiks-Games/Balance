using UnityEngine;
using System.Collections;

public class BoardController : MonoBehaviour
{

    public float speed = 0.2f;

    void Start()
    {

    }

    void FixedUpdate()
    {
        float moveVert = Input.GetAxis("Platform Vertical");
        Vector3 vec3 = new Vector3(0, 0, moveVert);

        this.transform.Rotate(vec3);
    }
}
