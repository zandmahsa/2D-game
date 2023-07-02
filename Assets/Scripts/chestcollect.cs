using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chestcollect : MonoBehaviour
{
    private player p;
	public Text coinnum;
	public AudioSource blingAudio;
    // Start is called before the first frame update
    void Start()
    {
        p = FindObjectOfType<player>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player")
		 {
			
			blingAudio.Play();
			
			int coins = int.Parse(coinnum.text);
			coins = coins + 10;
			coinnum.text = coins.ToString();
			
			Destroy(gameObject);
		}
	}
}
