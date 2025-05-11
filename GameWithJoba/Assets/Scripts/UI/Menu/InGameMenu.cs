using Core;
using Core.Ui;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Menu.InGame
{
    public class InGameMenu : MonoBehaviour
    {
        [SerializeField] private GameObject menu;
        [SerializeField] private SpriteButton continueButton;
        [SerializeField] private SpriteButton exitButton;

        private void Start() => Bind();

        private void OnDestroy() => Expose();

        private void ToggleMenu()
        {  
            if(menu.activeSelf)
                CloseMenu();
            else
                OpenMenu();
        }

        private void OpenMenu()
        {
            menu.SetActive(true);
            Cursor.visible = true;
            Time.timeScale = 0f;
        }

        private void CloseMenu()
        {
            menu.SetActive(false);
            Cursor.visible = false;
            Time.timeScale = 1f;
        }

        private void LoadMenu() => SceneManager.LoadScene(0);

        private void Bind()
        {
            continueButton.OnClick += ToggleMenu;
            exitButton.OnClick += LoadMenu;
        }

        private void Expose()
        {
            continueButton.OnClick -= ToggleMenu;
            exitButton.OnClick -= LoadMenu;
        }
    }
}