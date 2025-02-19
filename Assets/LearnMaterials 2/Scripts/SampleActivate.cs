using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleActivate : MonoBehaviour
{
    [SerializeField]
    private List<SampleScript> samples;
    public void Activate()
    {
        foreach (SampleScript script in samples)
        {
            script.Use();
        }
    }
}
