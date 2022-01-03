using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 15.0f;
    private Rigidbody rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, -speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("EndScreen", LoadSceneMode.Single);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < 0.0f)
        {
            BlazePoseSample.score++;

            Destroy(this.gameObject);
        }
    }
}
