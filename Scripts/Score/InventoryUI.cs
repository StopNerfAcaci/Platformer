using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TMP_Text berryText;
    // Start is called before the first frame update
    void Start()
    {
        berryText = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    public void UpdateBerryNum(PlayerInventory pi)
    {
        berryText.text = pi.numberOfBerries.ToString();
    }
}
