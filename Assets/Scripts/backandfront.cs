using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backandfront : MonoBehaviour
{
    
	public double distance;//The distance that Bad Guy go and go back
	public float speed;
	private float startx;//start position
	private int direction; //The point that according to its value (if it is zero or one) Bad Guy realizes that he must travel the forward path or return path.
	private player p;
	
	
	
    void Start()
    {
        p = FindObjectOfType<player>();
		startx = gameObject.transform.position.x;
		
    }

    void Update()
    {
        if(gameObject.transform.position.x < startx + distance && direction == 0)
		{
			gameObject.transform.position = new Vector2(
			gameObject.transform.position.x + speed, gameObject.transform.position.y);
		}
		
		if(gameObject.transform.position.x >= startx + distance && direction == 0)
		{
			direction = 1;
		}
		
		if(gameObject.transform.position.x > startx && direction == 1)
		{
			gameObject.transform.position = new Vector2(gameObject.transform.position.x - speed, gameObject.transform.position.y);	
		}
		
		if(gameObject.transform.position.x <= startx && direction == 1)
		{
			direction = 0;
		}
    }
}
