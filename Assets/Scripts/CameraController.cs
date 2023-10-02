using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] protected Transform player;


    protected virtual void Update()
    {
        if (player.position.y < transform.position.y) return;
         transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
        
    }
}
