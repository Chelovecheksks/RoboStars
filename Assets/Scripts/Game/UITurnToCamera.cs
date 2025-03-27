using UnityEngine;

public class UITurnToCamera : MonoBehaviour
{
    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
    }

    private void LateUpdate()
    {
        Work();
    }

    private void Work()
    {
        transform.forward = _camera.transform.forward;
    }
}
