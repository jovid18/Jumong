using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


/// <summary>
/// if layer or tag has been set and an object matching that (or if none then has anything) collides with us then fire collision events.
/// </summary>
public class EventOnCollision : MonoBehaviour
{
    public string checkTag = "";
    public int checkLayer = -1;

    //public UnityEvent arrowCollisionStart;
    //public UnityEvent arrowCollisionEnd;

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {


        //if (IsValidCollision(collision.gameObject))
        //{
        //    arrowCollisionStart?.Invoke();
        //}

        if (collision.gameObject.CompareTag("arrow"))
        {
            Debug.Log("Arrow is Collided");
            animator.SetBool("isDead", true);
            
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        //if (IsValidCollision(collision.gameObject))
        //{
        //    arrowCollisionEnd?.Invoke();
        //}
    }

    //bool IsValidCollision(GameObject collidedObject)
    //{
    //    //bool noCheck = true;
    //    bool valid = false;

    //    if (collidedObject.CompareTag("arrow"))
    //    {
    //        Debug.Log("Arrow is Collided");
    //        animator.SetBool("isDead", true);
    //        valid = true;
    //    }


    //    //if (checkTag.Length > 0)
    //    //{
    //    //    noCheck = false;
    //    //    if (collidedObject.CompareTag(checkTag))
    //    //    {
    //    //        valid = true;
    //    //    }
    //    //    else
    //    //    {
    //    //        return false;
    //    //    }
    //    //}
    //    //if (checkLayer >= 0)
    //    //{
    //    //    noCheck = false;
    //    //    if (collidedObject.layer == checkLayer)
    //    //    {
    //    //        valid = true;
    //    //    }
    //    //    else
    //    //    {
    //    //        return false;
    //    //    }
    //    //}
    //    //if (noCheck)
    //    //{
    //    //    valid = true;
    //    //}

    //    return valid;
    //}
}
