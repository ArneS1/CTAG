using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poempelReact : MonoBehaviour
{
    public AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("plunger")){
            audioSource.Play();
            //TODO: Wasser ablassen
            //TODO: Level gewinnen
        }
    }
}
