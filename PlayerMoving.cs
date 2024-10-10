using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    public float moveSpeed = 5; 
    public float leftrightSpeed = 4 ;
  
   
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed , Space.World );

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) )

        {
            if (this.gameObject.transform.position.x > LevelBoun.leftSide)
            {
            transform.Translate(Vector3.left * Time.deltaTime* leftrightSpeed * 1 );
            }
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < LevelBoun.rightSide)
            {
            transform.Translate(Vector3.left * Time.deltaTime * leftrightSpeed * -1 );
            }
        }   

    }   
}
