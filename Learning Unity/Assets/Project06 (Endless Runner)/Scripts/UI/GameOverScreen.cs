using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace EndlessRunner
{
    public class GameOverScreen : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private Button _restartButton;
        [SerializeField] private Button _exitButton;

        private CanvasGroup _canvasGroup;

        private void Awake() =>
            _canvasGroup = GetComponent<CanvasGroup>();
        
        private void OnEnable()
        {
            _restartButton.onClick.AddListener(OnRestartButtonClick);
            _exitButton.onClick.AddListener(OnExitButtonClick);

            _player.Died += TerminateGame;
        }
        private void OnDisable()
        {
            _restartButton.onClick.RemoveListener(OnRestartButtonClick);
            _exitButton.onClick.RemoveListener(OnExitButtonClick);

            _player.Died -= TerminateGame;
        }
        void Start() =>
            _canvasGroup.alpha = 0;

        private void TerminateGame()
        {
            _canvasGroup.alpha = 1;
            Time.timeScale = 0;
        }
        private void OnRestartButtonClick()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        private void OnExitButtonClick() =>
            Application.Quit();
    }
}
