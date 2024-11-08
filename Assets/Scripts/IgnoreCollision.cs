using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollision : MonoBehaviour
{
    [SerializeField] private Collider thisCollider;
    [SerializeField] private Collider[] colliderToIgnore;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Collider otherCollider in colliderToIgnore)
        {
            Physics.IgnoreCollision(thisCollider, otherCollider, true);
        }
    }

    
}
