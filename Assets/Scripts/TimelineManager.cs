using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Playables;

public class TimelineManager : MonoBehaviour
{
    [SerializeField] private PlayableDirector director;
    public bool hasEnter;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hasEnter = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player" && !hasEnter)
        {
            director.Play();
            Debug.Log("Start");
            hasEnter = true;
        }
    }
}
