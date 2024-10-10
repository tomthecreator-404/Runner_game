using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
   public string parentName;
    


    void Start()
    {
        parentName = transform.name; 
        StartCoroutine(DestroyClones());
        
    }

    IEnumerator DestroyClones()
    {
        yield return new WaitForSeconds(30);
        if (parentName == "Section(Clone)")
        {
            Destroy(gameObject);
        }
    }
}
