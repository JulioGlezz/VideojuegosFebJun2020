using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float speed;
    private Rigidbody bala;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("timer", 10, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //impulse(balas),explosion
        //valor de distancia de la bala 
        bala = gameObject.GetComponent<Rigidbody>();
        bala.velocity = new Vector3(0, 0,0);
        bala.AddForce(transform.forward*speed, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.tag!="Player")
        {
            Destroy(gameObject);
        }
    }
     void timer()
    {
        Destroy(gameObject);
    }
    
}
