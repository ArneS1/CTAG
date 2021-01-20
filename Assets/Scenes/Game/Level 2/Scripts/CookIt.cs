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
    public GameObject potFire;
    public GameObject StirCollider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void killFires(){
        bananaFire.SetActive(false);
        fishFire.SetActive(false);
        eyeFire.SetActive(false);
        potFire.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {

    if(other.gameObject.CompareTag("lighter")){
        fire = true;
    }
    if (fire) 
    {
        switch(other.gameObject.tag){
            case "banana":
                banana = true;
                other.gameObject.SetActive(false);
                killFires();
                bananaFire.SetActive(true);
                break;
            case "fish":
                fish = true;
                other.gameObject.SetActive(false);
                killFires();
                fishFire.SetActive(true);
                break;
            case "eye":
                eye = true;
                other.gameObject.SetActive(false);
                killFires();
                eyeFire.SetActive(true);
                break;
        }
        }
        if(banana && fish && eye)
        {
            StirCollider.SetActive(true);
        }
    }

}
