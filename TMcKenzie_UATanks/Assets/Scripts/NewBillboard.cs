using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBillboard : MonoBehaviour
{
    
    public Camera cameraToLookAt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void LateUpdate()
    {
        transform.LookAt(cameraToLookAt.transform);
    }
}
