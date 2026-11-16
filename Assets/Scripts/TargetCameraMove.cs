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
        _follow.HorizontalAxis.Value = GetAngle();
    }

    float GetAngle()
    {
        float dx = target.position.x - player.position.x;
        float dy = target.position.y - player.position.y;
        float rad = Mathf.Atan2(dx, dy);
        return rad * Mathf.Rad2Deg;
    }
}
