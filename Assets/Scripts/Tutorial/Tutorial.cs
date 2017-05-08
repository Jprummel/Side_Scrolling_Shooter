using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour {

    [SerializeField]private List<Collider2D> _tutorialTriggers = new List<Collider2D>();
    [SerializeField]private List<GameObject> _tutorialImages = new List<GameObject>();
    [SerializeField]private GameObject _firstTutorialImage;

    void OnTriggerEnter2D(Collider2D other)
    {
        for (int i = 0; i < _tutorialTriggers.Count; i++)
        {
            if (_tutorialTriggers[i] == other)
            {
                if (i == 0)
                {
                    _firstTutorialImage.SetActive(false); //Disable the first tutorial image
                }
                for (int j = 0; j < _tutorialImages.Count; j++)
                {
                        if (i != j)
                        {
                            _tutorialImages[j].SetActive(false); // Disable all tutorial images that are not supposed to be active
                        }

                        if (i <= j) //Checks if i is equal or equal to j to prevent errors
                        {
                        if (_tutorialImages[j] != null && i == j)
                        {
                            _tutorialImages[j].SetActive(true); // As long as there is a image in the slot that equals i, set it active
                        }
                    }
                }
                _tutorialTriggers[i].gameObject.SetActive(false); //Disables the collider to make sure it cant be triggered again
            }
        }
    }
}
