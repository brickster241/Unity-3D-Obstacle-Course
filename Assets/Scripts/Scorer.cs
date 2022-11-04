using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int scoreObjectsCollided = 0;
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.name != "Plane" && other.gameObject.tag != "Hit") {
            scoreObjectsCollided += 1;
            other.gameObject.tag = "Hit";
            Debug.Log("Collision with object detected. Object collided score : " + scoreObjectsCollided);
        }
    }
}
