using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GoalController : MonoBehaviour
{
    public GameObject collideObj;
    private Animator anim;
    public GameObject parent;

    void Start()
    {
        anim = GetComponentInParent<Animator>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Very sketchy way of doing it, make sure the *Goal* is above groud and can only be collided by the sphere
        foreach (var collisionPoint in collision.contacts)
        {
            if (collisionPoint.otherCollider == collideObj.GetComponent<Collider>())
            {
                anim.SetTrigger("Collide");

                LoadScene ld = parent.GetComponentInChildren<LoadScene>();
                anim.SetInteger("NextScene", ld.GetSceneNumber());
            }
        }
    }
}
