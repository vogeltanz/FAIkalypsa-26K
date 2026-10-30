using UnityEngine;

[RequireComponent(typeof(Animator))]
public class GhoulAI : MonoBehaviour
{
    Animator animator;

    [SerializeField]
    float playerDetectionRange = 10f;

    bool isPlayerVisible = false;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckPlayerVisibility(GameObject player)
    {
        if (player != null)
        {
            Vector3 originPosition = transform.position + transform.up * 1.5f;
            Vector3 playerPosition = player.transform.position + player.transform.up * 1.5f;
            Vector3 directionToPlayer = (playerPosition - originPosition).normalized;

            Physics.Raycast(originPosition, directionToPlayer, out RaycastHit hitInfo, playerDetectionRange, ~LayerMask.GetMask("Ignore Raycast"));
            Debug.DrawRay(originPosition, directionToPlayer * playerDetectionRange, Color.red);

            if (hitInfo.collider != null && hitInfo.collider.gameObject == player)
            {
                isPlayerVisible = true;
                animator.SetBool("PlayerIsVisible", isPlayerVisible);
            }
            else
            {
                isPlayerVisible = false;
                animator.SetBool("PlayerIsVisible", isPlayerVisible);
            }
        }
        else
        {
            isPlayerVisible = false;
            animator.SetBool("PlayerIsVisible", isPlayerVisible);
        }
    }
}
