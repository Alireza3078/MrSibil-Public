using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftSideWrap : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.transform.position = new Vector3(3f, col.gameObject.transform.position.y, 0);
        }
    }
}
