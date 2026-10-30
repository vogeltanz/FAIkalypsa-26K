using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    InputAction menuAction;

    bool isMenuOpen = false;

    void Awake()
    {
        menuAction = InputSystem.actions.FindAction("Menu");

        menuAction.performed += MenuAction_performed;
    }

    private void OnDestroy()
    {
        menuAction.performed -= MenuAction_performed;
    }

    private async void MenuAction_performed(InputAction.CallbackContext obj)
    {
        if (isMenuOpen == false)
        {
            Time.timeScale = 0f;
            SceneManager.LoadScene("Menu", LoadSceneMode.Additive);
            isMenuOpen = true;
        }
        else
        {
            await SceneManager.UnloadSceneAsync("Menu");
            isMenuOpen = false;
            Time.timeScale = 1f;
        }
    }
}
