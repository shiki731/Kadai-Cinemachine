using System.Collections;
using UnityEngine;

public class RootAttack : MonoBehaviour
{
    private float speed = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(rootAttack());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator rootAttack()
    {
        for (int i = 0; i < 10; i++)
        {
            transform.Translate(Vector3.up * speed);
            yield return new WaitForSeconds(0.05f);
        }
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }
}
