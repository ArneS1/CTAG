﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Spawn(ballPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn(GameObject gameObject){
        GameObject newObject = Instantiate(gameObject) as GameObject;
        newObject.transform.position = this.transform.position;
    }
}
