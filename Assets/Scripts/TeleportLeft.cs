using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportLeft : MonoBehaviour
{
    public RectTransform teleportTarget;
    public GameObject Player;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Player.transform.position = teleportTarget.transform.position;
    }
}
