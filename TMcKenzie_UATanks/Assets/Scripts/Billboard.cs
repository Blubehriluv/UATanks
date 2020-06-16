using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Transform MyTransform;
    public Transform MyCameraTransform;

    void Update()
    {
        MyTransform.forward = MyCameraTransform.forward;
    }
}
