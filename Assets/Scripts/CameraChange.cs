using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraChange : MonoBehaviour
{
    [SerializeField] private TimelineManager timeline;
    PlayerInput _input;

    public CinemachineCamera cameraA;
    public CinemachineCamera cameraB;

    private bool modeChange = false;
    private bool playerForrow;
    private bool hasStart = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _input = GetComponent<PlayerInput>();
    }

    public void OnModeChange(InputValue value)
    {
        modeChange = value.isPressed;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeline.hasEnter && !hasStart)
        {
            cameraModeChange();
            hasStart = true;
        }

        if(timeline.hasEnter && modeChange)
        {
            cameraModeChange();
        }
    }

    private void cameraModeChange()
    {
        playerForrow = !playerForrow;
        if (playerForrow)
        {
            Debug.Log("ModeChange");
            cameraA.Priority = 5;
            cameraB.Priority = 0;
        }
        else
        {
            cameraA.Priority = 0;
            cameraB.Priority = 5;
        }
        modeChange = false;
    }
}
