using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookIt : MonoBehaviour
{

    private bool fire = false;
    private bool banana = false;
    private bool fish = false;
    private bool eye = false;
    public GameObject bananaFire;
    public GameObject fishFire;
    public GameObject eyeFire;

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
        fire = true;
    }
    if (fire) {
        switch(other.gameObject.tag){
            case "banana":
                banana = true;
                bananaFire.SetActive(true);
                fishFire.SetActive(false);
                eyeFire.SetActive(false);
                break;
            case "fish":
                fish = true;
                fishFire.SetActive(true);
                bananaFire.SetActive(false);
                eyeFire.SetActive(false);
                break;
            case "eye":
                eye = true;
                eyeFire.SetActive(true);
                bananaFire.SetActive(false);
                fishFire.SetActive(false);
                break;
        }
        }
    }

}
