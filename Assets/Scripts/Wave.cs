using System.Collections;
using UnityEngine;

public class Wave : MonoBehaviour
{
    private float speed = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(waving());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator waving()
    {
        for (int i = 0; i < 20; i++)
        {
            transform.Translate(Vector3.forward * speed);
            yield return new WaitForSeconds(0.05f);
            transform.localScale += new Vector3(2.1f, 0, 0);
        }
        Destroy(gameObject);
    }
}
