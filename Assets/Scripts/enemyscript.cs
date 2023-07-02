using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour
{
    public AudioSource attackAudio;
    private int enemyhealth = 2;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("bubble"))// If the bubble hits the giant's collider, it will reduce the health of the giant until it is destroyed
        {
            attackAudio.Play();
            enemyhealth--;
            if(enemyhealth <= 0)
                Destroy(gameObject);

        }
    }
}
