using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnables : MonoBehaviour
{
    public List<GameObject> spawnables = null;
    private List<List<string>> spawnableNames;
    // Start is called before the first frame update
    void Start()
    {
        spawnableNames = new List<List<string>>();
        spawnables.ForEach(s =>{
            List<string> keywords = new List<string>(s.GetComponent<SpawnableKeywords>().keywords);
            spawnableNames.Add(keywords);
        });
        MySpawner.Instance.SetData(spawnables, spawnableNames);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
