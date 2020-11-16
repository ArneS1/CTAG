using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextEvaluator : MonoBehaviour
{
    // Start is called before the first frame update
    private List<List<string>> spawnableNames;

    public TextEvaluator()
    {
    } 
    
    public string GetSpawnableFromText(string text)
    {
        spawnableNames = new List<List<string>>(MySpawner.Instance.GetSpawnableNames());
        string name = "NULL";
        spawnableNames.ForEach(nameList => {
            nameList.ForEach(spawnableName => {
                if(text.Contains(spawnableName)){
                name = spawnableName;
                }
            });
        });
        Debug.Log("found: " + name);
        return name;
    }

    public int GetSizeFromText(string text){
        if(text.Contains("klein")){
            return 1;
        } else if(text.Contains("groß")){
            return 3;
        } else return 2;
    }
}
