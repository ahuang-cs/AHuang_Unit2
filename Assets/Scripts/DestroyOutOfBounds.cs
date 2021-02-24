using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topOfScene = 30f;
    private float bottomOfScene = -10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // TODO: avoid duplicating Destroy() by using || conditional instead of if/else
        if(transform.position.z > topOfScene)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < bottomOfScene)
        {
            Destroy(gameObject);
        }
    }
}
