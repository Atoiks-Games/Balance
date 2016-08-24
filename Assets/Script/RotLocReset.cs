using UnityEngine;
using System.Collections;

public class RotLocReset : MonoBehaviour
{

    private Vector3 oldPosition;
    private Quaternion oldRotation;

    // Use this for initialization
    void Start()
    {
        lock (this)
        {
            Transform inst = this.transform;
            this.oldPosition = new Vector3(inst.position.x, inst.position.y, inst.position.z);
            this.oldRotation = inst.rotation;
        }
    }

    public void ApplyReset()
    {
        lock (this)
        {
            this.transform.position = new Vector3(oldPosition.x, oldPosition.y, oldPosition.z);
            this.transform.rotation = this.oldRotation;
        }
    }
}
