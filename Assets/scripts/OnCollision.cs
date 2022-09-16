using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerCollision : MonoBehaviour
{
    // public PlayerMovement1 positions;
    
    void OnCollisionEnter(Collision collisionInfo){
        if(collisionInfo.collider.tag == "obstacle"){
            Debug.Log("We hit an obstacle");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            // movement.enabled = false;
            // FindObjectOfType<GameManager>().EndGame();
        }
        // Debug.Log(collisionInfo.collider.name);
    }
}