using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int numberOfBerries { get; private set; }
    public UnityEvent<PlayerInventory> OnBerryCollected;
    public void BerryCollect()
    {
        numberOfBerries++;
        OnBerryCollected.Invoke(this);
    }
}
