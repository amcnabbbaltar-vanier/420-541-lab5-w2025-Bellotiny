using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitBoxManager : MonoBehaviour
{
    public  Collider[] attackColliders;
    // Start is called before the first frame update
    void Start()
    {
        foreach(Collider attackCollider in attackColliders)
        {
            attackCollider.enabled = false; //Disable collider at start
        }
    }

    public void EnableHitBox()
    {
        foreach(Collider attackCollider in attackColliders)
        {
            attackCollider.enabled = true;
        }
    }

    public void DisableHitBox()
    {
        foreach(Collider attackCollider in attackColliders)
        {
            attackCollider.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
