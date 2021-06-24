using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public RecycleGameObjects prefab;
    private List<RecycleGameObjects> poolInstance = new List<RecycleGameObjects>();
    private RecycleGameObjects CreateInstance(Vector3 pos)
    {
        var clone = GameObject.Instantiate(prefab);
        clone.transform.position = pos;
        clone.transform.parent = transform;
        poolInstance.Add(clone);
        return clone;
    }
    public RecycleGameObjects NextObject(Vector3 pos)
    {
        RecycleGameObjects Instance = null;
        foreach (var go in poolInstance)
        {
            if (go.gameObject.activeSelf != true)
            {
                Instance = go;
                Instance.transform.position = pos;
            }
        }
        if (Instance == null)
        {
            Instance = CreateInstance(pos);
        }   
        Instance.Restart();
        return Instance;
    }
}
