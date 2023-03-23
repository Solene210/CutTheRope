using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LevelScore : MonoBehaviour
{
    #region Expose
    [SerializeField] private GameObject _passable;
    [SerializeField] private GameObject _bien;
    [SerializeField] private GameObject _formidable;
    [SerializeField] private IntVariable _nbStar;
    [SerializeField] private Image[] _starsImage;
    [SerializeField] private Sprite _emptyStar;
    [SerializeField] private Sprite _fullStar;
    #endregion

    #region Unity Life Cycle
    void Update()
    {
        foreach (Image img in _starsImage)
        {
            img.sprite = _fullStar;
        }
        for (int i = 0; i < _nbStar._value; i++)
        {
            _starsImage[i].sprite = _emptyStar;
        }
        TextScore();
    }
    #endregion

    #region methods
    private void TextScore()
    {
        if (_nbStar._value == 2)
        {
            _passable.SetActive(false);
            _formidable.SetActive(false);
            _bien.SetActive(true);
        }
        else if (_nbStar._value == 3)
        {
            _formidable.SetActive(true);
            _bien.SetActive(false);
            _passable.SetActive(false);
        }
        else if(_nbStar._value == 1 || _nbStar._value == 0)
        {
            _bien.SetActive(false);
            _formidable.SetActive(false);
            _passable.SetActive(true);
        }
    }
    #endregion

    #region Private & Protected

    #endregion
}