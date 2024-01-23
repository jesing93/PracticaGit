using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PatataScript : MonoBehaviour
{
    public int patatatas;

    private void Start()
    {
        if(City.Instance.curDayTime == 12)
        {
            patatatas += 1000000000;
        }
    }
}
