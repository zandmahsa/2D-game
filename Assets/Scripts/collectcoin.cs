using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectcoin : MonoBehaviour
{
	private player p;
	public Text coinnum;
	public AudioSource blingAudio;
	
	void Start(){
		p = FindObjectOfType<player>();
	}
	
    private void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player")
		 {
			blingAudio.Play();
			
			int coins = int.Parse(coinnum.text);
			coins++;
			coinnum.text = coins.ToString();
			
			Destroy(gameObject);
		}
	}
				
}
