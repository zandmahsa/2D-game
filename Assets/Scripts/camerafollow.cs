using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform player; // value for access the player  
    private Vector3 lastposition; //  to find the last position of player
    public float minY = -1f; //  value for the ground how depth tiles it should shown

    void LateUpdate()
    {
        if(lastposition == null)
            lastposition = transform.position;
        if(player.position != lastposition)
        {
            transform.position = new Vector3(player.position.x, Mathf.Clamp(player.position.y, minY,Mathf.Infinity), -10f);// follow the player 
            lastposition = transform.position;
        }
        
    }
}
