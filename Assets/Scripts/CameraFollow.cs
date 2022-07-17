using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform AghaFirooz;
    public Transform AmooKhosro;
    public Transform FerySibil;
    public Transform HashemKhan;
    public Transform MrKamy;

    


    void LateUpdate()
    {
        if (AghaFirooz.position.y > transform.position.y-5)
        {
            Vector3 newPos = new Vector3(transform.position.x, AghaFirooz.position.y+5, transform.position.z);
            transform.position = newPos;
        }
        if (AmooKhosro.position.y > transform.position.y+3)
        {
            Vector3 newPos = new Vector3(transform.position.x, AmooKhosro.position.y-3, transform.position.z);
            transform.position = newPos;
        }
        if (FerySibil.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, FerySibil.position.y, transform.position.z);
            transform.position = newPos;
        }
        if (HashemKhan.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, HashemKhan.position.y, transform.position.z);
            transform.position = newPos;
        }
        if (MrKamy.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, MrKamy.position.y, transform.position.z);
            transform.position = newPos;
        }


    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
     
    //    Destroy(collision.transform.gameObject);
    //}
}