using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerCounter : BaseCounter
{
    [SerializeField] private KitchenObjectsSO kitchenObjectSO;

    public event EventHandler OnPlayerGrabbedObject;



    public override void Interact(Player player)
    {
        OnPlayerGrabbedObject?.Invoke(this, EventArgs.Empty);
        Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);
        kitchenObjectTransform.GetComponent<KitchenObject>().SetKitchenObjectParent(player);
    }

    

}
