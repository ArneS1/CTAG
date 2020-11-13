using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySpawner : MonoBehaviour
{
    private List<GameObject> spawnables;
    private List<string> spawnableNames;

    private static MySpawner instance = null;
    private static readonly object padlock = new object();

    public void Start(){
    }

    MySpawner()
    {
    }

    public static MySpawner Instance
    {
        get
        {
            lock (padlock)
            {
            if (instance == null)
            {
                instance = new MySpawner();
            }
            return instance;
            }
        }
    }

    /*
    string objectName = object to be spawned (e.g. "ball", "cube", "dice", ...)
    int size = value from 1-3 -> 1=small 2=regular 3=large
    */
    public void Spawn(string name, int size){
        GameObject spawnable = null;

        if(spawnableNames.Contains(name))
        {
            spawnable = spawnables[spawnableNames.IndexOf(name)];
            GameObject newObject = Instantiate(spawnable) as GameObject;
            newObject.transform.position = this.transform.position;
            if( size >= 1 && size <= 3)
            {
                newObject.transform.localScale = GetSizeVector(size);
            }
        }
    }

    private Vector3 GetSizeVector(int size)
    {
        Vector3 vector = new Vector3(1.0f, 1.0f , 1.0f);
        switch(size)
        {
            case 1:
                vector.x = 0.5f;
                vector.y = 0.5f;
                vector.z = 0.5f;
                break;

            case 2:
                break;

            case 3:
                vector.x = 2f;
                vector.y = 2f;
                vector.z = 2f;
                break;            
        }
    return vector;
    }

    public List<string> GetSpawnableNames(){
        return this.spawnableNames;
        //TODO check if not null
    }

    public void SetData(List<GameObject> spawnables, List<string> spawnableNames){
        this.spawnables = spawnables;
        this.spawnableNames = spawnableNames;
        Debug.Log("MYSPAWNER: data set");
        //TODO check if not null
    }
}
