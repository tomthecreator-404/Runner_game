using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndRunSRC : MonoBehaviour
{
    public GameObject liveDis; 
    public GameObject endScreen ; 
    public GameObject fadeOut; 
    // Start is called before the first frame update
    void Start()
    {
        
       StartCoroutine(EndSequence());

    }

    IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(3);
        liveDis.SetActive(false);
        endScreen.SetActive(true);
        yield return new WaitForSeconds(3);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }

   
}
