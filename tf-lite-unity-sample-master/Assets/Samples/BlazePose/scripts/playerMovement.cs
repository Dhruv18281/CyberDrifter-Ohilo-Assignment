using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private BlazePoseSample bpsample;
    private float bend;

    // Start is called before the first frame update
    void Start()
    {
        GameObject bp = GameObject.Find("BlazePose");
        bpsample = bp.GetComponent<BlazePoseSample>();
    }

    // Update is called once per frame
    void Update()
    {
        bend = bpsample.bend;

        transform.Translate(new Vector3(20*bend, 0, 0)*Time.deltaTime);
    }
}
