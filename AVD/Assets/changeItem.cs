using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class changeItem : MonoBehaviour
{
    public EquipmentItem Rake;
    public GameObject moose;

    public void ObtainLegendaryRake()
    {
        Debug.Log("Signal Received");
        moose.GetComponent<CharacterData>().Equipment.Equip(Rake);
    }

}
