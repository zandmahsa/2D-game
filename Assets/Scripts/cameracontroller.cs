using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    public GameObject player;// for access to the player
	public float offset;//value for set an offset
	private Vector3 playerposition;// for find the possition of the player 
	public float offsetsmothing;//smoth camera
	

    // Update is called once per frame
    void Update()
    {
        playerposition = new Vector3(player.transform.position.x,transform.position.y,transform.position.z);// set the values of players's position
		if(player.transform.localScale.x > 0f)// for access the distance 
		{
			playerposition = new Vector3(playerposition.x + offset,playerposition.y,playerposition.z); 
		}
		else
		{
			playerposition = new Vector3(playerposition.x - offset,playerposition.y,playerposition.z);
			
		}
		transform.position = Vector3.Lerp(transform.position,playerposition,offsetsmothing * Time.deltaTime);
    }
}
