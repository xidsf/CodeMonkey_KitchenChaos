using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    [SerializeField]
    private KitchenObjectsSO kitchenObjectsSO;
    [SerializeField]
    private Transform counterTopPoint;

    public void Interact()
    {

        Transform kitchenObjecTransform = Instantiate(kitchenObjectsSO.prefab, counterTopPoint);
        kitchenObjecTransform.localPosition = Vector3.zero;
        Debug.Log(kitchenObjecTransform.GetComponent<KitchenObject>().GetKitchenObjectSO().objectName);
        
    }
}
