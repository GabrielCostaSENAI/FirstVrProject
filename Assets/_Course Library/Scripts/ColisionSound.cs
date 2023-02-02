using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionSound : MonoBehaviour
{


    [SerializeField] private AudioClip audioImpactBall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision == LayerMask(default))
        {

        }


    }



}
