using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StirParent : MonoBehaviour
{
    public GameObject stir1;
    public GameObject stir2;
    public GameObject stir3;
    public GameObject stir4;
    public GameObject stir5;
    public GameObject door;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(!stir1.activeInHierarchy 
        && !stir2.activeInHierarchy 
        && !stir3.activeInHierarchy 
        && !stir4.activeInHierarchy 
        && !stir5.activeInHierarchy )
        {
            door.SetActive(true);
        }
    }
}
