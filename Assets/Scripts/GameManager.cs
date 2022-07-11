using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Tooltip("�ő僉�C�t")]
    [SerializeField] int _maxLife = 50;
    [Tooltip("�������C�t")]
    [SerializeField] int _initialLife = 10;
    [Tooltip("���C�t�Q�[�W")]
    [SerializeField] Slider _lifeGauge;
    /// <summary>�X�R�A�e�L�X�g </summary>
    [SerializeField] Text _scoreText = default;
    [Tooltip("GmaOver�̂��")]
    [SerializeField] GameObject _gameOver;
    [Tooltip("�Q�[���I�[�o�[�̃X�R�A�e�L�X�g")]
    [SerializeField] Text _gameOverText;

    int _life = 0;
    int _score = 0;
    // Start is called before the first frame update
    void Start()
    {
        _life = _initialLife;
        _score = 0;
        _gameOver.SetActive(false);
        AddLife(0);
        AddScore(0);
        Time.timeScale = 1;
    }

    private void Update()
    {
        if(_life < 0)
        {
            _gameOver.SetActive(true);
            _gameOverText.text = "SCORE " + _score;
            //Debug.Log("GameOver");
            Time.timeScale = 0;
        }
    }

    public void AddLife(int life)
    {
        _life += life;
        _lifeGauge.value = (float)_life / _maxLife;
    }
    public void AddScore(int score)
    {
        _score += score;
        _scoreText.text = _score.ToString("D5");
    }
    public int Scoer
    {
        get
        {
            return _score;
        }
    }
}
