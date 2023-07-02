using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class heartcollect : MonoBehaviour
{
    private player p;
	public Text heartnum;
	public AudioSource heartAudio;
	
	void Start(){
		p = FindObjectOfType<player>();
	}
	
    private void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player")
		 {
			heartAudio.Play();
			
			int hearts = int.Parse(heartnum.text);
			hearts++;
			heartnum.text = hearts.ToString();
            gamecontrolscript.health += 1;
			
			Destroy(gameObject);
		}
	}
}
