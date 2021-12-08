using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    [SerializeField] private Animator UIAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void RemoveUIMenu()
    {
        UIAnimator.SetTrigger("EnterButtom");
    }
}
