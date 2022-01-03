using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    public float spawnTimemax = 0.75f;
    public float spawnTimemin = 2.0f;
    public float curtime = 0;
    public float offset = 0.05f;
    private bool running = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void spawn()
    {
        GameObject e = Instantiate(enemy) as GameObject;
        e.transform.position = new Vector3(Random.Range(4f, -4f), 1.37f, 117.0f);
    }

    private void FixedUpdate()
    {
        GameObject bp = GameObject.Find("BlazePose");
        BlazePoseSample bpsample = bp.GetComponent<BlazePoseSample>();
        bool d = bpsample.detected;
        if (!running && d)
        {
            StartCoroutine(enemywave());
            running = true;
        }

        if(running)
        {
            curtime += Time.deltaTime * offset;
        }
    }

    IEnumerator enemywave()
    {
        while (true)
        {
            yield return new WaitForSeconds(Mathf.Lerp(spawnTimemax, spawnTimemin, Mathf.Min(1, curtime)));
            spawn();
        }
    }
}
