using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarCount : MonoBehaviour
{
    #region Expose
    public int _stars = 0;
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
        for (int i = 0; i < _stars; i++)
        {
            _starsImage[i].sprite = _emptyStar;
        }
    }
    #endregion
}
