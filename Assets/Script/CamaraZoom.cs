using UnityEngine;
using Cinemachine;

public class CameraZoom : MonoBehaviour
{
    [SerializeField] private CinemachineFreeLook freeLookCamera;

    [SerializeField] private float zoomSpeed = 2f;
    [SerializeField] private float zoomSmoothSpeed = 5f;

    [SerializeField] private float minDistance = 2f;
    [SerializeField] private float maxDistance = 6f;

    private PlayerInput playerInput;

    private float targetDistance;

    private void Awake()
    {
        playerInput = new PlayerInput();

        // เริ่มต้นด้วยระยะของ Middle Rig
        targetDistance = freeLookCamera.m_Orbits[1].m_Radius;
    }

    private void Update()
    {
        float zoomInput = playerInput.onFoot.Zoom.ReadValue<float>();

        // Scroll Mouse
        if (zoomInput != 0)
        {
            targetDistance -= zoomInput * zoomSpeed;

            targetDistance = Mathf.Clamp(
                targetDistance,
                minDistance,
                maxDistance
            );
        }

        // ค่อย ๆ ซูมไปหา targetDistance
        var orbits = freeLookCamera.m_Orbits;

        for (int i = 0; i < orbits.Length; i++)
        {
            orbits[i].m_Radius = Mathf.Lerp(
                orbits[i].m_Radius,
                targetDistance,
                zoomSmoothSpeed * Time.deltaTime
            );
        }

        freeLookCamera.m_Orbits = orbits;
    }

    private void OnEnable()
    {
        playerInput.onFoot.Enable();
    }

    private void OnDisable()
    {
        playerInput.onFoot.Disable();
    }
}