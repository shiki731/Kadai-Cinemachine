using Unity.Cinemachine;
using UnityEngine;

public class TargetCameraMove : MonoBehaviour
{
    private CinemachineOrbitalFollow _follow;
    public Transform target;
    public Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _follow = GetComponent<CinemachineOrbitalFollow>();
    }

    // Update is called once per frame
    void Update()
    {
        float dx = target.position.x - player.position.x;
        float dz = target.position.z - player.position.z;
        float rad = Mathf.Atan2(dz, dx) ;
        float angle = rad * Mathf.Rad2Deg;
        _follow.HorizontalAxis.Value = angle * -1.0f + 90.0f;
    }

}
