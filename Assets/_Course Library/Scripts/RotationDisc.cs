using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class RotationDisc : MonoBehaviour
{
    [SerializeField] private float velocityRotation;

    // Update is called once per frame
    void Update()
    {
        RotationDiscOnGame();
    }


    public void RotationDiscOnGame()
    {
        transform.Rotate(new Vector3(0, velocityRotation, 0));
    }


}
