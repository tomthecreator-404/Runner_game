using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{

       public GameObject thePlayer;  
       public GameObject charModel; 
       public AudioSource crashThud;
       public GameObject mainCam; 
       public GameObject levelControl;

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false; 
        thePlayer.GetComponent<PlayerMoving>().enabled = false ; 
        charModel.GetComponent<Animator>().Play("Damage_02");
        levelControl.GetComponent<LevelDistance>().enabled = false;
        crashThud.Play() ;
        mainCam.GetComponent<Animator>().enabled = true ; 
        levelControl.GetComponent<EndRunSRC>().enabled = true; 


    }
}
