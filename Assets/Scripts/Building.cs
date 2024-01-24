using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    //The building preset
    public BuildingPresets preset;
    public GameObject sillaGeimin;
    public GameObject sillaNormal;
    public bool luces;


    public void Update()
    {
        if(sillaGeimin == null)
        {
            sillaGeimin.SetActive(true);
        }
        else if(sillaGeimin != null)
        {
            sillaGeimin = null;
        }

        if (luces) sillaNormal = sillaGeimin;
    }

    private void FixedUpdate()
    {
        Update();

        Debug.Log("Fokiu");
    }
}
