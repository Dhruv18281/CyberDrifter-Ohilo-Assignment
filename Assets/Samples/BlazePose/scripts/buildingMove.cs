using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingMove : MonoBehaviour
{
    private int speed = 10;

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(new Vector3(0, 0, speed * Time.deltaTime * -1), Space.World);
        if(this.transform.position.z < 0f)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 103f);
        }
    }
}
