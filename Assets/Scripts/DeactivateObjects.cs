using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateObjects : MonoBehaviour
{
    HUD hud;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject thing in hud.destroyedObjects)
        {
            thing.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
