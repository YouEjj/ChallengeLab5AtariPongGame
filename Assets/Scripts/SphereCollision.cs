using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        
    }
    // Update is called once per frame
    void Update()
    {

    }
    private bool dir = false;
    private int score1 = 0;
    private int score2 = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if(dir)
        {
            if (collision.gameObject.CompareTag("player1"))
            {

                this.GetComponent<Rigidbody>().AddForce(200, 1, -400);


            }
            if (collision.gameObject.CompareTag("player2"))
            {

                this.GetComponent<Rigidbody>().AddForce(-200, 1, 400);

            }
            dir = true;
        }
        else
        {
            if (collision.gameObject.CompareTag("player1"))
            {

                this.GetComponent<Rigidbody>().AddForce(-200, 1, -400);
                
            }
            if (collision.gameObject.CompareTag("player2"))
            {

                this.GetComponent<Rigidbody>().AddForce(200, 1, 400);
                
            }
            dir = false;
        }

        if (collision.gameObject.CompareTag("mur"))
        {

            this.GetComponent<Rigidbody>().AddForce(100, 1, -300);
            

        }

        if (collision.gameObject.CompareTag("mur2"))
        {

            this.GetComponent<Rigidbody>().AddForce(-100, 1, 300);
            

        }

        if (collision.gameObject.CompareTag("but2"))
        {
            score1++;
            Debug.Log("Player 1 : " + score1 + " | " + score2 + " : Player 2");
            transform.position = new Vector3(0.21f, 0.3f, -8.8f);
            transform.rotation = Quaternion.identity;


        }

        if (collision.gameObject.CompareTag("but1"))
        {
            score2++;
            Debug.Log("Player 1 : " + score1 + " | " + score2 + " : Player 2");
            transform.position = new Vector3(0.21f, 0.3f, 8.85f);
            transform.rotation = Quaternion.identity;


        }
    }
}