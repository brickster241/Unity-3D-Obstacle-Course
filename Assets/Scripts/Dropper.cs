using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    // Start is called before the first frame update
    private bool hasTimeElapsed = false;
    private MeshRenderer meshRenderer;
    private Rigidbody rigidBody;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        meshRenderer.enabled = false;
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > 3 && !hasTimeElapsed) {
            Debug.Log("Enabling Gravity...");
            meshRenderer.enabled = true;
            hasTimeElapsed = true;
            rigidBody.useGravity = true;
        }
    }
}
