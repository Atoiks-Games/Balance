using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GoalController : MonoBehaviour
{
    public GameObject collideObj;
    public string jumpScene;

    IEnumerator OnCollisionEnter(Collision collision)
    {
        // Very sketchy way of doing it, make sure the *Goal* is above groud and can only be collided by the sphere
        foreach (var collisionPoint in collision.contacts)
        {
            if (collisionPoint.otherCollider == collideObj.GetComponent<Collider>())
            {
                yield return GetComponentInParent<Animation>().WhilePlaying("OnCollide");
                SceneManager.LoadScene(jumpScene);
            }
        }
    }
}
