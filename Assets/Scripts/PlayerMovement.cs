using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
       // Start is called before the first frame update
    [SerializeField] float speed = 8f;
    void Start()
    {
        Debug.Log("Starting Player Movement...");
        gameObject.tag = "Player";
    }

    // Update is called once per frame
    void Update()
    { 
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(x, 0, z);
    }
}
