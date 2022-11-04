using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSpinner : MonoBehaviour
{
    [SerializeField] float xangle = 0;
    [SerializeField] float yangle = 0.3f;
    [SerializeField] float zangle = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Rotating Spinners....");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xangle, yangle, zangle);
    }
}
