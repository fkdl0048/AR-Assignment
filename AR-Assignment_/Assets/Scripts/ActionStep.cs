using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class ActionStep : MonoBehaviour
{
    [Header("Step")]
    public string stepName;
    [TextArea(3, 10)]
    public string stepText;
    
    private DOTweenAnimation _tweenAnimation;

    private void Awake()
    {
        _tweenAnimation = GetComponent<DOTweenAnimation>();
    }

    public void SetStep(TextMeshProUGUI text, Animator animator)
    {
        _tweenAnimation.DOPlay();
        
        DOTween.Kill(text);
        text.text = "";
        text.DOText(stepText, 2f);
        
        animator.Play(stepName);
    }
}
