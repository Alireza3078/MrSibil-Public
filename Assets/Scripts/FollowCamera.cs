using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform Target;
    public float FollowSpeed;

    private void FixedUpdate()
    {
        if (Target.position.y > transform.position.y)
        {
            Vector3 targetpos = new Vector3(transform.position.x, Target.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, targetpos, FollowSpeed * Time.deltaTime);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.transform.parent.gameObject);
    }
}
