using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    [SerializeField]
    private KitchenObjectsSO kitchenObjectsSO;

    private IKitchenObjectParent kitchenObjectParent;

    public KitchenObjectsSO GetKitchenObjectSO()
    {
        return kitchenObjectsSO;
    }


    public IKitchenObjectParent GetKitchenObjectParent()
    {
        return kitchenObjectParent;
    }    

    public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
    {
        if(this.kitchenObjectParent != null)
        {
            this.kitchenObjectParent.ClearKitchenObject();
        }

        this.kitchenObjectParent = kitchenObjectParent;
        if (kitchenObjectParent.HasKitchenObject())
        {
            Debug.LogError("KitchenObjectParent가 이미 KitchenObject가 있음");
        }
        kitchenObjectParent.SetKitchenObject(this);

        transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
        transform.localPosition = Vector3.zero;

    }

}
