using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    [SerializeField]
    private KitchenObjectsSO kitchenObjectsSO;

    private ClearCounter clearCounter;

    public KitchenObjectsSO GetKitchenObjectSO()
    {
        return kitchenObjectsSO;
    }


    public ClearCounter GetClearCounter()
    {
        return clearCounter;
    }    

    public void SetClearCounter(ClearCounter clearCounter)
    {
        if(this.clearCounter != null)
        {
            this.clearCounter.ClearKitcheknObject();
        }

        this.clearCounter = clearCounter;
        if (clearCounter.HasKitchenObject())
        {
            Debug.LogError("이미 KitchenObject가 있음");
        }
        clearCounter.SetKitchenObject(this);

        transform.parent = clearCounter.GetKitchenObjectFollowTransform();
        transform.localPosition = Vector3.zero;

    }

}
