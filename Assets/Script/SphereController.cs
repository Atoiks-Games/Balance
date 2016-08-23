using UnityEngine;
using System.Collections;

public class SphereController : MonoBehaviour
{

    public float speed;
    public Rigidbody rbody;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHoriz = 0;
        float moveVert = 0;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveVert = 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            moveVert = -1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveHoriz = -1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveHoriz = 1;
        }

        Vector3 vec3 = new Vector3(moveHoriz, 0, moveVert);

        rbody.AddForce(vec3 * speed);
    }
}
