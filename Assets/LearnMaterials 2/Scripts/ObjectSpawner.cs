using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : SampleScript
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private int count = 5; 
    [SerializeField] private float step = 2f;

    [ContextMenu("Use")]
    public override void Use()
    {
        if (prefab == null)
        {
            Debug.LogError("Префаб не назначен!", this);
            return;
        }

        for (int i = 0; i < count; i++)
        {
            Vector3 position = transform.position + new Vector3(i * step, 0, 0);
            Instantiate(prefab, position, Quaternion.identity);
        }
    }
}
