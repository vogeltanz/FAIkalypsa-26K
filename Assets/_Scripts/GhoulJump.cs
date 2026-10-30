using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class GhoulJump : MonoBehaviour
{
    InputAction _jumpAction;

    Rigidbody _rigidbody;

    [SerializeField]
    private float _jumpVelocity = 5f;

    bool _isGrounded;

    void Awake()
    {
        _jumpAction = InputSystem.actions.FindAction("Jump");
        _rigidbody = GetComponent<Rigidbody>();

        _jumpAction.performed += jumpAction_performed;
    }

    void OnDestroy()
    {
        _jumpAction.performed -= jumpAction_performed;
    }

    private void jumpAction_performed(InputAction.CallbackContext obj)
    {
        if (_isGrounded)
        {
            _rigidbody.linearVelocity = new Vector3(_rigidbody.linearVelocity.x, _jumpVelocity, _rigidbody.linearVelocity.z);
        }
    }

    public void SetIsGrounded(bool isGrounded)
    {
        _isGrounded = isGrounded;
    }
}
