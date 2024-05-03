using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    //After this time, the object will be destroyed
    [Header("Default Destruction Time")]
    public float timeToDestruction;

    // Start is called before the first frame update
    void Start()
    {
    //Execute DestroyObjecet function based on timeToDestruction
    Invoke("DestroyObject", timeToDestruction);
    }

    //This function will destroy this object
    void DestroyMe () {
        //Destroy object
        Destroy (gameObject);
    }
}

