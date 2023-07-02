using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroylight : MonoBehaviour
{
    private player p;
	
	
	void Start(){
		p = FindObjectOfType<player>();// find the object in the scene
	}
	
    private void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player") // Whenever the player hits this light, destroy the light 
		 {
			Destroy(gameObject);
		}
	}
}
