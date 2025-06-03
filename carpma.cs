using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class carpma : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Þu an bu metod boþ, ama hata olmamasý için bu þekilde tanýmlanmalý
    }

    private void OnCollisionEnter(Collision collision)

    {
        if (collision.collider.tag == "engel")
        {
            Invoke("restart", 3f);
        }
    }

    private void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
