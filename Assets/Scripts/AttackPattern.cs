using UnityEngine;

public class AttackPattern : MonoBehaviour
{
    public GameObject wave1;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Wave()
    {
        Debug.Log("wave");

        GameObject obj1 = GameObject.Instantiate(wave1);
        obj1.transform.position = gameObject.transform.position;
        obj1.transform.rotation = Quaternion.Euler(0,0,0);

        GameObject obj2 = GameObject.Instantiate(wave1);
        obj2.transform.position = gameObject.transform.position;
        obj2.transform.rotation = Quaternion.Euler(0, 90, 0);

        GameObject obj3 = GameObject.Instantiate(wave1);
        obj3.transform.position = gameObject.transform.position;
        obj3.transform.rotation = Quaternion.Euler(0, 180, 0);

        GameObject obj4 = GameObject.Instantiate(wave1);
        obj4.transform.position = gameObject.transform.position;
        obj4.transform.rotation = Quaternion.Euler(0, -90, 0);

    }
}
