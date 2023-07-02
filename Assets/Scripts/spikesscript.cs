using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikesscript : MonoBehaviour
{
	private player p;
	public AudioSource hurtAudio;
	void Start(){
		p = FindObjectOfType<player>();
	}

    void OnTriggerEnter2D(Collider2D col)
	{
		if(col.tag == "Player")
		{
			hurtAudio.Play();
		    gamecontrolscript.health -= 1;
		}
		
	}
}
