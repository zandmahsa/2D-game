using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling : MonoBehaviour
{
    private player p; //  making on object p from the Class of player
	public GameObject gameOver;
	
	void Start(){
		
		p = FindObjectOfType<player>(); // find the object that is already an script in our project
	}
	private void OnTriggerEnter2D(Collider2D other){ // if player falls and touch the collider of falling object in our project
		if(other.tag == "Player")
		{
			gameOver.gameObject.SetActive(true);
			Time.timeScale = 0;
		}
	}
}
