using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] GameObject shockwavePrefab;
    [SerializeField] GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")){
            // sets game over to true 
            gameManager.gameOver = true;
            //creates a shockwave
            Instantiate(shockwavePrefab, transform.position, Quaternion.identity);
	        //destroys key
            Destroy(gameObject, 0.1f);
        }
    }
}
