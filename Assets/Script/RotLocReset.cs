using UnityEngine;
using System.Collections;

public class RotLocReset : MonoBehaviour
{

    private Vector3 oldPosition;
    private Quaternion oldRotation;

    // Use this for initialization
    void Start()
    {
        Transform inst = this.transform;
        this.oldPosition = new Vector3(inst.position.x, inst.position.y, inst.position.z);
        this.oldRotation = inst.rotation;
    }

    public void ApplyReset()
    {
        this.transform.position = new Vector3(oldPosition.x, oldPosition.y, oldPosition.z);
        this.transform.rotation = this.oldRotation;

        Rigidbody rbody = this.GetComponent<Rigidbody>();
        if (rbody != null)
        {
            rbody.velocity = Vector3.zero;
            rbody.angularVelocity = Vector3.zero;
        }
    }
}
