using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public BuildingPresets preset;
    public GameObject sillaGeimin;


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
    }

    private void FixedUpdate()
    {
        Update();

        Debug.Log("Fokiu");
    }
}
