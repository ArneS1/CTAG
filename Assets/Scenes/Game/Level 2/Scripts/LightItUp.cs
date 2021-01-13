using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightItUp : MonoBehaviour
{

    public GameObject PotFire;
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
        if(other.gameObject.CompareTag("lighter")){
           PotFire.SetActive(true);
        }
    }
}
