using UnityEngine;
using System.Collections;

public class BoardController : MonoBehaviour
{

    public float speed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Rotate(this.transform.right, speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Rotate(this.transform.right, -speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(this.transform.forward, speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(this.transform.forward, -speed);
        }
    }
}
