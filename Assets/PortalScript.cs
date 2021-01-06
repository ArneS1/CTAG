using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PortalScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");
        if(other.gameObject.CompareTag("Player")){
            SceneManager.LoadScene("Level 2");
        }
    }
}
