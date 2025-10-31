using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    public Rigidbody rb;

       private void Start()
        {
            rb.useGravity = false;
        }

           
 
    
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
              rb.useGravity = true;
              Debug.Log("Collided with Player");   
        }
    }
}
