using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnableKeywords : MonoBehaviour
{
    public List<string> keywords = null;
    
    public List<string> getKeywords(){
        return keywords;
    }
}
