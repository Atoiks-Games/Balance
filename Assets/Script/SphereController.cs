using UnityEngine;
using System.Collections;

public class SphereController : MonoBehaviour
{

    public float speed;
    private Rigidbody rbody;

    void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHoriz = Input.GetAxis("Sphere Horizontal");
        float moveVert = Input.GetAxis("Sphere Vertical");

        Vector3 vec3 = new Vector3(moveHoriz, 1f, moveVert);

        rbody.AddForce(vec3 * speed);
    }
}
