using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireOnOff : MonoBehaviour
{
    public GameObject Fire;

    private MeshRenderer meshRenderer = null;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnDestroy()
    {

    }

    public void FireOn(XRBaseInteractor interactor){
        Fire.SetActive(true);
    }

     public void FireOff(XRBaseInteractor interactor){
        Fire.SetActive(false);
    }
}