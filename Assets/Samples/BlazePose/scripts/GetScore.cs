using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GetScore : MonoBehaviour
{
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        score.text = BlazePoseSample.score.ToString();
    }
}
