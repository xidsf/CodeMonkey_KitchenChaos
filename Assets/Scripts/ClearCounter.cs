using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    [SerializeField]
    private KitchenObjectsSO kitchenObjectsSO;
    [SerializeField]
    private Transform counterTopPoint;

    private KitchenObject kitchenObject;

    [SerializeField]
    private ClearCounter secondClearCounter;
    public bool Test;


    private void Update()
    {
        if(Test && Input.GetKeyDown(KeyCode.T))
        {
            if(kitchenObject != null)
            {
                kitchenObject.SetClearCounter(secondClearCounter);
            }
        }
    }

    public void Interact()
    {
        if(kitchenObject == null)
        {
            Transform kitchenObjecTransform = Instantiate(kitchenObjectsSO.prefab, counterTopPoint);
            kitchenObjecTransform.GetComponent<KitchenObject>().SetClearCounter(this);
            
        }
        else
        {
            Debug.Log(kitchenObject.GetClearCounter());
        }
    }

    public KitchenObject GetKitchenObject()
    {
        return kitchenObject;
    }

    public void SetKitchenObject(KitchenObject kitchenObject)
    {
        this.kitchenObject = kitchenObject;
    }

    public void ClearKitcheknObject()
    {
        kitchenObject = null;
    }

    public bool HasKitchenObject()
    {
        return (kitchenObject != null);
    }

    public Transform GetKitchenObjectFollowTransform()
    {
        return counterTopPoint;
    }
}
