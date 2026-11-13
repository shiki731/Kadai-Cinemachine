using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEditor.SceneView;

public class PlayerCameraMove : MonoBehaviour
{
    private PlayerInput _input;
    private CinemachineOrbitalFollow _follow;

    private Vector2 cameraMove;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _input = GetComponent<PlayerInput>();
        _follow = GetComponent<CinemachineOrbitalFollow>();
    }

    public void OnLook(InputValue value)
    {
        cameraMove = value.Get<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
        _follow.HorizontalAxis.Value += cameraMove.x * -1.0f;
    }
}
