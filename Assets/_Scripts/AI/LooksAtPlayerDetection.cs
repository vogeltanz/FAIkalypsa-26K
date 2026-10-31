using UnityEngine;

[RequireComponent(typeof(Animator))]
public class LooksAtPlayerDetection : MonoBehaviour
{
    Animator animator;

    [SerializeField]
    float detectionRange = 2f;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 originPosition = transform.position + transform.up * 1.5f;
        Vector3 direction = transform.forward;

        Physics.Raycast(originPosition, direction, out RaycastHit hitInfo, detectionRange, ~LayerMask.GetMask("Ignore Raycast"));
        Debug.DrawRay(originPosition, direction * detectionRange, Color.green);

        if (hitInfo.collider != null && hitInfo.collider.CompareTag("Player"))
        {
            animator.SetBool("LooksAtPlayer", true);
        }
        else
        {
            animator.SetBool("LooksAtPlayer", false);
        }
    }
}
