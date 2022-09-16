using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onCollision : MonoBehaviour
{
    public Transform player;
    void OnCollisionEnter(Collision collisionInfo){
        if(collisionInfo.collider.tag == "obstacle"){
            Debug.Log("We hit an obstacle");
            // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Restart(0);
        }
        if(collisionInfo.collider.tag == "Finish"){
            Debug.Log("Level finished");
            // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Restart(1);
        }
    }
    void Update(){
        Debug.Log(player.position.y);
        if(player.position.y < -50){
            Restart(0);
            // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    public void Restart(int i){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+i);
    }
}
