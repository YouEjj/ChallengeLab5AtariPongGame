using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeysPlayer1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private float moveSpeed = 10.0f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }

    }
}
