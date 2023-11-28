using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScenController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private TextMeshProUGUI textMeshProUGUI;
    
    [Header("Action Steps")]
    [SerializeField] private ActionStep[] actionSteps;
    
    private int _currentStep = 0;
    
    private void Start()
    {
        actionSteps[_currentStep]?.SetStep(textMeshProUGUI, animator);
        _currentStep++;
    }
    
    public void LoadScene(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }

    private void Update()
    {
        // touch or click
        if (Input.GetMouseButtonDown(0))
        {
            if (_currentStep >= actionSteps.Length)
            {
                return;
            }
            actionSteps[_currentStep++]?.SetStep(textMeshProUGUI, animator);
        }
    }
}
