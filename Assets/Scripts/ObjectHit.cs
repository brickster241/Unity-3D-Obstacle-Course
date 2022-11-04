using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        Debug.Log("Inside OnCollisionEnter Method...");
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        if (other.gameObject.name == "Player") {
            meshRenderer.material.color = Color.red;
        } 
    }
}
