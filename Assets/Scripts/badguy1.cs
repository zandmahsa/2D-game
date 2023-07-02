using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badguy1 : MonoBehaviour
{
    private player p;
	public GameObject blood;
	
	void Start()
	{
		p = FindObjectOfType<player>();
	}
	private void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player")
		{
			StartCoroutine("delay");
			
		}
	}
	public IEnumerator delay()
	{
		Instantiate(blood, p.transform.position,p.transform.rotation);
		p.enabled = false;
		p.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
		p.GetComponent<Renderer>().enabled = false;
		
		yield return new WaitForSeconds(1);
		p.transform.position = new Vector2(0f,0f);
		p.GetComponent<Renderer>().enabled = true;
		p.enabled = true;
		
	}
}
