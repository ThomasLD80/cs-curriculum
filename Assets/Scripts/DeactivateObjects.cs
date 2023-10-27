using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DeactivateObjects : MonoBehaviour
{
    HUD hud;
    public static DeactivateObjects deactObj;

    // Start is called before the first frame update
    void Start()
    {
        List<GameObject> objectsInScene = new List<GameObject>();

        foreach (GameObject go in Resources.FindObjectsOfTypeAll(typeof(GameObject)) as GameObject[])
        {
            if (EditorUtility.IsPersistent(go.transform.root.gameObject) )
                objectsInScene.Add(go);
        }

        print(objectsInScene.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
