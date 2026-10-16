using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Animator))]
public class GhoulController : MonoBehaviour
{
    Animator _animator;
    InputAction _moveAction;

    [SerializeField]
    float moveSpeed = 2f;

    void Awake()
    {
        _animator = GetComponent<Animator>();
        _moveAction = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        var moveValue = _moveAction.ReadValue<Vector2>();

        if (moveValue.x == 0 && moveValue.y == 0)
        {
            _animator.SetBool("IsWalking", false);
        }
        else
        {
            _animator.SetBool("IsWalking", true);
            
            Vector3 moveDirection = new Vector3(moveValue.x, 0, moveValue.y);
            transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
        }
    }
}
