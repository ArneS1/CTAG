using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poempelReact : MonoBehaviour
{
    public AudioSource audioSource;

    public int poempelCount = 0;
    
    public GameObject Level1VictoryCanvas;

    public GameObject Water;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        switch(poempelCount){
            case 1:
                lowerWater1();
                break;
            case 2:
                lowerWater2();
                break;
            case 3:
                lowerWater3();
                Level1VictoryCanvas.SetActive(true);
                break;
        }

        if(poempelCount > 3){
            Level1VictoryCanvas.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("plunger")){
            audioSource.Play();
            //TODO: Wasser ablassen
            //TODO: Level gewinnen
            poempelCount++;
        }
    }

    private void lowerWater1(){
        Vector3 step1 = new Vector3(0f, -0.25f, 0f);
        Water.transform.position = step1;

        Vector3 size1 = new Vector3(0.85f, 1f, 0.97f);
        Water.transform.localScale = size1;
    }

    private void lowerWater2(){
        Vector3 step2 = new Vector3(0f, -0.5f, 0f);
        Water.transform.position = step2;

        Vector3 size2 = new Vector3(0.76f, 1f, 0.88f);
        Water.transform.localScale = size2;
    }

    private void lowerWater3(){
        Vector3 step3 = new Vector3(0f, -0.75f, 0f);
        Water.transform.position = step3;

        Vector3 size3 = new Vector3(0.61f, 1f, 0.82f);
        Water.transform.localScale = size3;
    }
}
