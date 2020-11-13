using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnables : MonoBehaviour
{
    public List<GameObject> spawnables = null;
    private List<string> spawnableNames;
    // Start is called before the first frame update
    void Start()
    {
        spawnableNames = new List<string>();
        spawnables.ForEach(s =>{
            string name = s.ToString();
            name = name.Replace(" (UnityEngine.GameObject)","");
            name = name.ToLower();
            Debug.Log("Spwanable " + name + " added.");
            spawnableNames.Add(name);
        });
        MySpawner.Instance.SetData(spawnables, spawnableNames);
        //TODO check if not null
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
