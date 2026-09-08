using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour
{
    public static GameAssets i { get; private set; }

    private void Awake()
    {
        i = this;
    }

    public GameObject pfItemWorld;

    
}
