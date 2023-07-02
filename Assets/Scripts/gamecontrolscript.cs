using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontrolscript : MonoBehaviour
{
    public GameObject h1,h2,h3,gameOver;
	public static int health;// variable for health of player
	
    void Start()
    {
		health = 3;
		h1.gameObject.SetActive(true);
		h2.gameObject.SetActive(true);
		h3.gameObject.SetActive(true);
		gameOver.gameObject.SetActive(false);
        
    }

    
	//For times when any of the following situations occur
    void Update()
    {
		if(health>3)
			health = 3;
		switch(health)
		{
			case 3:
				h1.gameObject.SetActive(true);//the number of hearts is still 3
				h2.gameObject.SetActive(true);
				h3.gameObject.SetActive(true);
				break;
			case 2:
				h1.gameObject.SetActive(true);//the number of hearts is 2
				h2.gameObject.SetActive(true);
				h3.gameObject.SetActive(false);
				break;
			case 1:
				h1.gameObject.SetActive(true);//the number of hearts is 1
				h2.gameObject.SetActive(false);
				h3.gameObject.SetActive(false);
				break;
			case 0:
				h1.gameObject.SetActive(false);//the number of hearts is 0 and the game is over 
				h2.gameObject.SetActive(false);
				h3.gameObject.SetActive(false);
				gameOver.gameObject.SetActive(true);// show the game over message
				Time.timeScale = 0;
				break;
			
		}
        
    }
}
