using UnityEngine;
using UnityEngine.Events;

public class GroundDetection : MonoBehaviour
{
    public UnityEvent<bool> OnGroundChanged;

    bool _isGrounded;

    private void OnTriggerEnter(Collider other)
    {
        if (_isGrounded == false)
        {
            _isGrounded = true;
            OnGroundChanged?.Invoke(_isGrounded);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (_isGrounded == false)
        {
            _isGrounded = true;
            OnGroundChanged?.Invoke(_isGrounded);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _isGrounded = false;
        OnGroundChanged?.Invoke(_isGrounded);
    }
}
