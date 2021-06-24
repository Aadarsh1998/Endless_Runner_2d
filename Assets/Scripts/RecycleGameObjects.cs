using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecycleGameObjects : MonoBehaviour
{
    // Start is called before the first frame update
    public void Restart()
    {
        gameObject.SetActive(true);
    }

    public void Shutdown()
    {
        gameObject.SetActive(false);
    }
}
