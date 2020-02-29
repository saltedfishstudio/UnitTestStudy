using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldTo : MonoBehaviour
{
    Camera camera;
    
    // Start is called before the first frame update
    void Awake()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 viewport = camera.WorldToViewportPoint(transform.position);
        Debug.Log($"{viewport.x}, {viewport.y}, {viewport.z}");
    }
}
