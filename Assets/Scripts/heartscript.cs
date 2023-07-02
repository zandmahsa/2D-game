using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartscript : MonoBehaviour
{
	
    void OnTriggerEnter2D(Collider2D col)
	{
		gamecontrolscript.health += 1;// if player go into the heart objects increase the heart object
		
	}
}
